# MAUI_01_01_BindableLayout.App
.NET MAUI Layout 연습-BindableLayout

유튜브 참고: https://www.youtube.com/watch?v=Gxo-85Cbii8

#### 실행화면
![image](https://user-images.githubusercontent.com/68939699/228249709-e2501fcf-9889-4ff7-b937-70f1e6c859f6.png)

#### Code
```
<StackLayout>
        <Frame BackgroundColor="CadetBlue" Padding="24"  CornerRadius="0">
            <Label Text="BindableLayout Sample" FontSize="26"
                   HorizontalTextAlignment="Center" TextColor="White" />
        </Frame>
        <StackLayout BindableLayout.ItemsSource="{Binding MyStringList}">
            <BindableLayout.ItemTemplate>
                <DataTemplate>
                    <Label Text="{Binding .}" Margin="0,40,0,0" 
                           FontSize="18"
                           HorizontalTextAlignment="Center"/>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
            <BindableLayout.EmptyView>
                <Label Text =" Noting to here " Margin="0,40,0,0" HorizontalTextAlignment="Center" />
            </BindableLayout.EmptyView>
        </StackLayout>
        <Button Text="Clear" Command="{Binding ClearCommand}" Margin="0,40,0,0"  />
</StackLayout>
```
