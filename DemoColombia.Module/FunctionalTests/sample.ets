;#DropDB DemoColombiaEasyTest

#Application DemoColombiaWin
#Application DemoColombiaWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef DemoColombiaWin

*Action About...
 
*Action OK

#EndIf

#IfDef DemoColombiaWeb
*Action Navigation(My Details)
#EndIf
