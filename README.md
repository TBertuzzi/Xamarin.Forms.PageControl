# Xamarin.Forms.PageControl

use the iOS paging control with Xamarin.Forms
 
You can use any image in the paging control
 
###### This is the component, works on iOS and Android.

![](https://github.com/TBertuzzi/Xamarin.Forms.PageControl/blob/master/Resources/sample.png?raw=true)

**NuGet**

|Name|Info|
| ------------------- | :------------------: |
|PageControl|[![NuGet](https://buildstats.info/nuget/Xamarin.Forms.PageControl)](https://www.nuget.org/packages/Xamarin.Forms.PageControl/)|




**Platform Support**

MultiSelectListView is a .NET Standard 2.0 library.Its only dependency is the Xamarin.Forms

## Setup / Usage

In the Xaml file we must declare our control 
xmlns:ci="clr-namespace:Xamarin.Forms.PageControl;assembly=Xamarin.Forms.PageControl" , for example . 

Uses the properties to define the images that will be displayed. Enter the index to save which page is selected.

Properties

* ShowIndicator : Displays the paging control.
* IndicatorHeight x IndicatorWidth : Control the size of paging images.
* SelectedIndicator x UnselectedIndicator : Image displayed on pagination.
* Position : Index indicating the page.
* ItemsSource : Collection of objects to feed control.

Example :

```csharp

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:PageControlSample"
             x:Class="PageControlSample.MainPage" 
              xmlns:ci="clr-namespace:Xamarin.Forms.PageControl;assembly=Xamarin.Forms.PageControl" 
           Padding="0,20,0,0">

    <StackLayout>
        <Label Text="PageControl sample" />

        <ci:PageControl ShowIndicator="{Binding ShowIcons}" IndicatorHeight="8" IndicatorWidth="8" UnselectedIndicator="unselected_circle.png" SelectedIndicator="selected_circle.png" Position="{Binding Position}" ItemsSource="{Binding Screenshots}" />

        <Image Source="{Binding Image}"></Image>
       
    </StackLayout>

</ContentPage>


```
The complete example can be downloaded here: https://github.com/TBertuzzi/Xamarin.Forms.PageControl/tree/master/XFPageControlSample


