# WpfExercise
Create a WPF applications, and implement various features using C# 

The app have "Next Page" and "Previous Page" buttons on each screen and it acting like web browser to navigate between pages. 
In app NavigationWindows is used to navigate between pages, this is useful when need enter data steb by step.

Page1: Allow enter user name, has 2 buttons, the navigation window allow to store changed data into journal when navigate between pages, it require 8 complex steps to implement, for simplicity just save user name in aplication user settings, than retrieve it on page 2.

Page2: Show 2 ComboBoxes and rectangle, selecting colors will change rectangle color. Rectangle background color and stroke color binding to ComboBox.SelectedItem. Converter is used in combobox to show user frendly(by adding space) color name Alice Blue vs AliceBlue.  

Page 3: Using AForge from NuGet to get video from Web Camera and show in page3. AForge computer vision library contain Video player component for WinForm, so WPF WindowsFormHost component used to host VideoPlayer component in WPF application. AForge library provide video strem from web cam and must properly disposed manualy in code when application do not use web camera.

Page4: Getting simple weather info from openweathermap.orp web api. App make a call to service using HttpClient and receive JSON response.
Use Newtonsoft.Json library from NuGet used to convert JSON string to object. This implementation use MVVM(Model ViewModel Views) design pattern to organise code and simplify unit testing. Added RelayCommand in c# code and use Command and CommandParameter in XAML 'Get Weather' button, use commands allow simplify integration test, commands can be invoked from code. 
