Imports System.ServiceProcess

<System.ComponentModel.RunInstaller(True)> Partial Class ProjectInstaller
    Inherits System.Configuration.Install.Installer
    Private serviceInstaller As ServiceInstaller
    Private processInstaller As ServiceProcessInstaller

    Public Sub New()
        ' Instantiate installers for process and services.
        processInstaller = New ServiceProcessInstaller()
        serviceInstaller = New ServiceInstaller()

        ' The services run under the system account.
        processInstaller.Account = ServiceAccount.LocalSystem

        ' The services are started manually.
        serviceInstaller.StartType = ServiceStartMode.Automatic

        ' ServiceName must equal those on ServiceBase derived classes.
        serviceInstaller.ServiceName = "MySQL Backup Central"
        serviceInstaller.Description = "The way this application works, is that saves some fields nods in MS Access Database file containing database credentials, of those database which needs backup. The windows service will then locate and search this MS Access database file every seconds and perform a database backup if the start time matches the local system current time. A Microsoft library (DLL) then keeps the functionally separated so both the windows service and the graphic user interface can use it. "

        ' Add installers to collection. Order is not important.
        Installers.Add(serviceInstaller)
        Installers.Add(processInstaller)
    End Sub

End Class
