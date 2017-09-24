using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ABSCBN
{
    class NFCReader
    {
        IntPtr HIDHandle;
        int HIDAddress;

        public NFCReader()
        {

            HIDHandle = IntPtr.Zero;
            HIDAddress = 0;
        }
        public IntPtr GetHIDHandle()
        {
            return HIDHandle;
        }

        [DllImport("C:\\Users\\elise\\Documents\\Visual Studio 2017\\Projects\\tryme\\ABSCBN\\ABSCBN\\HIDdll.dll", EntryPoint = "API_USBGetConnectedDeviceNum")]
        static extern int API_USBGetConnectedDeviceNum();
        public int GetHIDDevice(ref int device_num)
        {
            device_num = API_USBGetConnectedDeviceNum();
            if (device_num > 0)
                return 0;
            else
                return -1;
        }

        [DllImport("C:\\Users\\elise\\Documents\\Visual Studio 2017\\Projects\\tryme\\ABSCBN\\ABSCBN\\HIDdll.dll", EntryPoint = "API_USBOpenWithNum")]
        static extern int API_USBOpenWithNum(ref IntPtr HIDHandle, int DeviceIndex, short NumInputBuffers);
        public int OpenHIDDevice(int DeviceIndex)
        {
            int status = API_USBOpenWithNum(ref HIDHandle, DeviceIndex, 0x40);
            if (status == 0)
            {
                return 0;
            }
            else if (status == 1)
            {
                return -1;
            }
            else
            {
                return -2;
            }
        }

        [DllImport("C:\\Users\\elise\\Documents\\Visual Studio 2017\\Projects\\tryme\\ABSCBN\\ABSCBN\\HIDdll.dll", EntryPoint = "API_USBMF_Read")]
        static extern int API_USBMF_Read(IntPtr HIDHandle, int HIDAddress, byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte buf);
        public int HID_Read_14443A(byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Read(HIDHandle, HIDAddress, mode, blockaddress, blocknum, ref key, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("C:\\Users\\elise\\Documents\\Visual Studio 2017\\Projects\\tryme\\ABSCBN\\ABSCBN\\HIDdll.dll", EntryPoint = "API_USBMF_Write")]
        static extern int API_USBMF_Write(IntPtr HIDHandle, int HIDAddress, byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte text, ref byte buf);
        public int HID_Write_14443A(byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte text, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Write(HIDHandle, HIDAddress, mode, blockaddress, blocknum, ref key, ref text, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("C:\\Users\\elise\\Documents\\Visual Studio 2017\\Projects\\tryme\\ABSCBN\\ABSCBN\\HIDdll.dll", EntryPoint = "API_USBMF_Inc")]
        static extern int API_USBMF_Inc(IntPtr HIDHandle, int HIDAddress, byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf);
        public int HID_IncreaseEP_14443A(byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Inc(HIDHandle, HIDAddress, mode, sector, ref key, ref EP_value, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("C:\\Users\\elise\\Documents\\Visual Studio 2017\\Projects\\tryme\\ABSCBN\\ABSCBN\\HIDdll.dll", EntryPoint = "API_USBMF_Dec")]
        static extern int API_USBMF_Dec(IntPtr HIDHandle, int HIDAddress, byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf);
        public int HID_DecreaseEP_14443A(byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Dec(HIDHandle, HIDAddress, mode, sector, ref key, ref EP_value, ref buf);
            }
            else
            {
                return -1;
            }
        }


        public string ReadCard()
        {
            String serialNumber = null;
            String strTmp = null;
            byte[] buf = new byte[128];
            byte[] key = new byte[8];

            byte mode = (byte)0;
            byte blockaddress = (byte)1;
            byte blocknum = (byte)1;

            key = CharToByte("FF FF FF FF FF FF");

            int ret = HID_Read_14443A(mode, blockaddress, blocknum, ref key[0], ref buf[0]);
            if (ret == 0)
            {

                for (int i = 0; i < key[0]; i++)
                {
                    serialNumber += string.Format("{0:X2}", key[i + 1]);
                }

                
                
                strTmp = null;
                for (int i = 0; i < 16 * blocknum; i++)
                {
                    strTmp += string.Format("{0:X2}", buf[i]);
                }

                //tb14443A_message.Text += "\r\nReceived data from card is " + strTmp;
                //tb14443A_message.AppendText("\r\n");
            }
            else if (ret == -1)
            {
                MessageBox.Show("No Hardware Found!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            return serialNumber;
        }

        public string ConnectHardware()
        {
            int device_num = 0;

            int retrievedDevice = GetHIDDevice(ref device_num);
            if (retrievedDevice == 0)
            {
                retrievedDevice = OpenHIDDevice(device_num - 1);
                if (retrievedDevice == 0)
                {
                    if (IntPtr.Zero != GetHIDHandle())
                    {
                        //success
                        return ReadCard();
                        
                    }
                    else
                    {
                        //failed
                        MessageBox.Show("Error");
                    }
                }
                else if (retrievedDevice == -1)
                {
                    //no reader
                    MessageBox.Show("Reader Not Found!");
                }
                else
                {
                    //error
                }
                
            }
            else if (retrievedDevice == -1)
            {
                //no reader
                MessageBox.Show("Reader Not Found!");

            }
            else
            {
                //error
            }
            return "No Card Detected";
        }

        public static string StrToHexStr(string str)
        {
            string strTemp = "";
            int i, len;
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'f') ||
                    (str[i] >= 'A' && str[i] <= 'F') ||
                    (str[i] >= '0' && str[i] <= '9') ||
                    str[i] == 0)
                {
                    strTemp += (char)str[i];
                }
            }
            return strTemp;
        }

        public static byte[] CharToByte(string str)
        {
            string strTmp;
            strTmp = StrToHexStr(str);
            str = strTmp;
            strTmp = "";
            byte[] tmpByte = new byte[1024];

            for (int i = 0; i < str.Length; i += 2)
            {
                strTmp += str[i];
                if (i + 1 < str.Length)
                {
                    strTmp += str[i + 1];
                }
                tmpByte[i / 2] = (byte)HexStringToInt(strTmp);
                strTmp = "";
            }
            return tmpByte;
        }

        public static int HexStringToInt(string hexStr)
        {
            string strTmp = StrDelete0X(hexStr);
            int iOutput = int.Parse(strTmp, System.Globalization.NumberStyles.HexNumber);
            return iOutput;
        }

        public static string StrDelete0X(string str)
        {
            string strTmp = "";
            byte[] byteTmp = new byte[16];

            if ('0' == str[0] && ('x' == str[1] || 'X' == str[1]))
            {
                strTmp += (char)str[2];
                strTmp += (char)str[3];
            }
            else
            {
                strTmp = str;
            }
            return strTmp;
        }
    }
}
