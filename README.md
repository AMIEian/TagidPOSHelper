# TagidPOSHelper
This library is developed for Ginesys tech team to provide sold barcodes data back to Tagid POS software.
It uses clipboard for data sharing.
It has single method with 2 overloades.

public static void PutBilledBarcodes(List\<string> barcodes)  //Parameter - List of barcode strings
  
public static void PutBilledBarcodes(string barcodes) //Parameter - string of comma (,) separated barcodes eg: 12345,6789,2345,6789

Please find sample project on following link -

https://github.com/AMIEian/POSAutoSellTestApp
