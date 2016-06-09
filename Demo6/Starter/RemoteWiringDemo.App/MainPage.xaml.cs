using Microsoft.Maker.Serial;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace RemoteWiringDemo.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private UsbSerial _Serial;


        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            _Serial = new UsbSerial(await FindFirstArduinoBoard());

            _Serial.ConnectionEstablished += () =>
            {
                Debug.WriteLine("Serial connection established");
            };

            _Serial.ConnectionFailed += (m) =>
            {
                Debug.WriteLine("Serial connection failed because " + m);
            };

            _Serial.begin(57600);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }


        private async Task<DeviceInformation> FindFirstArduinoBoard()
        {
            var usbDevices = await UsbSerial.listAvailableDevicesAsync();
            return usbDevices.FirstOrDefault(d => d.Name.ToUpper().Contains("ARDUINO"));
        }
    }
}
