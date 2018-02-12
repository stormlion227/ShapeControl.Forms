# ShapeControl.Forms

<img src="ScreenShots/IMG_E1117.JPG" width="50%" height="50%" align="right"/>

Xamarin.Forms plugin to draw shapes such as circle, rounded rectangle, oval and so on.

Supports Android, iOS and Unified Windows Platform (UWP, UAP).

[![NuGet](https://img.shields.io/nuget/v/ShapeControl.Forms.svg)](https://www.nuget.org/packages/ShapeControl.Forms/)

## Features

* Circle
* Oval
* RoundedRect
* Borderless Entry (SSEntry)
* Borderless Editor (SSEditor)
* Borderless Picker (SSPicker)
* Borderless DatePicker (SSDatePicker)
* Effects by using [SkiaSharp library](https://www.nuget.org/packages/SkiaSharp.Views.Forms).

## Support Platforms

* iOS 8+
* Android
* Universal Windows Platform (Win10/UWP)

## Setup
Install the [nuget package](https://www.nuget.org/packages/ShapeControl.Forms/) in portable and all platform specific projects..

#### Android
In MainActivity.cs file
```
	Stormlion.ShapeControl.Droid.Platform.Init(this);
```

#### iOS
In AppDelegate.cs file
```
	Stormlion.ShapeControl.iOS.Platform.Init();
```

#### UWP
In App.xaml.cs file
```
	List<Assembly> assebliesToInclude = new List<Assembly>();

	assebliesToInclude.Add(typeof(Stormlion.ShapeControl.UWP.Platform).GetTypeInfo().Assembly);

	Xamarin.Forms.Forms.Init(e, assebliesToInclude);
```
## Usage

### Circle Example

```
    <shapes:Circle>
        <shapes:Circle.Paint>
            <shapes:SSPaint BorderWidth="1" 
                            BorderColor="Red"
                            FillColor="Yellow"
                            />
        </shapes:Circle.Paint>
    </shapes:Circle>
```

### Oval with Blue Solid Color

```
    <shapes:Oval>
        <shapes:Oval.Paint>
            <shapes:SSPaint FillColor="Blue"
                            />
        </shapes:Oval.Paint>
    </shapes:Oval>
```

### RoundRect with Gridient Color

```
    <shapes:RoundRect RadiusX="30"
                      RadiusY="30"
                      >
        <shapes:RoundRect.Paint>
            <shapes:SSPaint BorderWidth="10"
                            FillColor="Transparent"
                            >
                <shapes:SSPaint.BorderShader>
                    <skiaSharp:SKShader x:FactoryMethod="CreateLinearGradient"
                                        >
                        <x:Arguments>
                            <skiaSharp:SKPoint>
                                <x:Arguments>
                                    <x:Single>0</x:Single>
                                    <x:Single>0</x:Single>
                                </x:Arguments>
                            </skiaSharp:SKPoint>
                            <skiaSharp:SKPoint>
                                <x:Arguments>
                                    <x:Single>255</x:Single>
                                    <x:Single>0</x:Single>
                                </x:Arguments>
                            </skiaSharp:SKPoint>
                            <x:Array Type="{x:Type skiaSharp:SKColor}">
                                <shapes:SKColorMarkup Value="Blue" />
                                <shapes:SKColorMarkup Value="Red" />
                            </x:Array>
                            <x:Array Type="{x:Type x:Single}">
                                <x:Single>0</x:Single>
                                <x:Single>1</x:Single>
                            </x:Array>
                            <skiaSharp:SKShaderTileMode>
                                Clamp
                            </skiaSharp:SKShaderTileMode>
                        </x:Arguments>
                    </skiaSharp:SKShader>                                
                </shapes:SSPaint.BorderShader>
            </shapes:SSPaint>
        </shapes:RoundRect.Paint>
    </shapes:RoundRect>
```

### Borderless Entry

```
	<shapes:SSEntry Text="No Border Entry" />
```

## Contributions
Contributions are welcome!

### Contributors

* **[Marko Rothstein](https://www.facebook.com/profile.php?id=100014026622428)**
