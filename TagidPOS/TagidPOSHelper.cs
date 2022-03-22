using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TagidPOS
{
    public class TagidPOSHelper
    {
        public static void PutBilledBarcodes(List<string> barcodes)
        {
            Clipboard.Clear();
            string data = "Tgid";
            foreach(string barcode in barcodes)
            {
                data = data + barcode + ",";
            }
            data = data.Remove(data.Length - 1);
            Clipboard.SetText(data);
        }

        public static void PutBilledBarcodes(string barcodes)
        {
            Clipboard.Clear();
            Clipboard.SetText("Tagid" + barcodes);
        }
    }
}
