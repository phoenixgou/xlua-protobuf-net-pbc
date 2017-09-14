set tool=..\..\..\..\Tools\protobuf-net

for %%i in (*.proto) do (    
echo %%i  
%tool%\protoc.exe --descriptor_set_out=../Resources/pb4lua/%%i.bytes ./%%i
%tool%\protogen.exe -i:%%i -o:..\%%i.cs
)  



pause