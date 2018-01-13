# ShapeControl.Forms

Xamarin.Forms library that allows you to draw shapes from a shared/portable library.
Supports Android, iOS and Unified Windows Platform (UWP, UAP)

### Features

* Circle
* Oval
* RoundedRect
* Color Effect by using [SkiaSharp library](https://github.com/mono/SkiaSharp).

### Support Platforms

* iOS 8+
* Android
* Universal Windows Platform (Win10/UWP)

### Usage

##### Circle with Stroke

```
  <StackLayout Orientation="Vertical"
               >
      <shapes:Circle HeightRequest="200"
                     >
          <shapes:Circle.Paint>
              <skiabase:SKPaint Style="Stroke"
                                Color="{shapesExtension:SKColorMarkup Red}"
                                StrokeWidth="1"
                                />
          </shapes:Circle.Paint>
      </shapes:Circle>
   </StackLayout>
```

##### Oval with Fill Color

```
  <StackLayout Orientation="Vertical"
    <shapes:Oval HeightRequest="200"
                 >
        <shapes:Oval.Paint>
            <skiabase:SKPaint Style="StrokeAndFill"
                              StrokeWidth="10"
                              Color="{shapesExtension:SKColorMarkup Blue}"
                              />
        </shapes:Oval.Paint>
    </shapes:Oval>
  </StackLayout>
```

#### RoundRect with Gridient Color

```
  <StackLayout Orientation="Vertical"
      <shapes:RoundRect HeightRequest="200"
                        RadiusX="30"
                        RadiusY="30"
                        >
          <shapes:RoundRect.Paint>
              <skiabase:SKPaint Style="StrokeAndFill"
                                StrokeWidth="5"
                                >
                  <skiabase:SKPaint.Shader>
                      <skiabase:SKShader x:FactoryMethod="CreateLinearGradient"
                                         x:Name="shader1"
                                         >
                          <x:Arguments>
                              <skiabase:SKPoint>
                                  <x:Arguments>
                                      <x:Single>0</x:Single>
                                      <x:Single>0</x:Single>
                                  </x:Arguments>
                              </skiabase:SKPoint>
                              <skiabase:SKPoint>
                                  <x:Arguments>
                                      <x:Single>255</x:Single>
                                      <x:Single>255</x:Single>
                                  </x:Arguments>
                              </skiabase:SKPoint>
                              <x:Array Type="{x:Type skiabase:SKColor}">
                                  <shapesExtension:SKColorMarkup Value="Green" />
                                  <shapesExtension:SKColorMarkup Value="Yellow" />
                              </x:Array>
                              <x:Array Type="{x:Type x:Single}">
                                  <x:Single>0</x:Single>
                                  <x:Single>1</x:Single>
                              </x:Array>
                              <skiabase:SKShaderTileMode>
                                  Clamp
                              </skiabase:SKShaderTileMode>
                          </x:Arguments>
                      </skiabase:SKShader>
                  </skiabase:SKPaint.Shader>
              </skiabase:SKPaint>
          </shapes:RoundRect.Paint>
      </shapes:RoundRect>
  </StackLayout>
```

#### ScrenShot

<img src="screen-shot1.png" />
