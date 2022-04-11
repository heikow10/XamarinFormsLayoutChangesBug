# XamarinFormsLayoutChangesBug
Minimal app to reproduce https://github.com/xamarin/Xamarin.Forms/issues/15066

How to reproduce:
1. Run the Android application on a device
2. Click the 'Add' button until the height of the dark green StackLayout is larger than the height of the page
3. Scroll to the end of the page

<img src="https://github.com/heikow10/XamarinFormsLayoutChangesBug/blob/1506e834d54a9d9e5ace541e1007857f02f11f4f/Screenshot_20220117_181613_com.companyname.xamarinformslayoutchangesbug.jpg" alt="XamarinFormsLayoutChangesBug: screenshot with the bug" title="XamarinFormsLayoutChangesBug: screenshot with the bug" style="width: 400px;" />
