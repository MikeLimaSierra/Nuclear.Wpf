@ECHO OFF

SET sn_exe="C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\sn.exe"
SET key=..\KeyPair.snk
SET tfm=%1
SET bin=..\..\bin\Nuclear.Wpf.Data\AnyCPU\Release\%tfm%\
SET publish=..\..\publish\Nuclear.Wpf.Data\%tfm%\
SET dll=Nuclear.Wpf.Data.dll
SET pdb=Nuclear.Wpf.Data.pdb
SET xml=Nuclear.Wpf.Data.xml
SET deps=Nuclear.Wpf.Data.deps.json

REM delete publish dir
RMDIR /S /Q %publish%

REM resign assembly
%sn_exe% -Ra %bin%%dll% %key%

REM verify assembly in bin
%sn_exe% -vf %bin%%dll%

REM copy output to publish dir
robocopy %bin% %publish% %dll% %pdb% %xml% %deps%

REM verify assembly in publish
%sn_exe% -vf %publish%%dll%