﻿Imports System.Runtime.InteropServices

Friend Class InpOut32

    <DllImport("Inpout32.dll")> Friend Shared Sub Out32(ByVal PortAddress As Short, ByVal Data As Short)
    End Sub

    <DllImport("Inpout32.dll")> Friend Shared Function Inp32(ByVal PortAddress As Short) As Short

    End Function

    <DllImport("Inpout32.dll")> Friend Shared Function IsInpOutDriverOpen() As Boolean

    End Function

    <DllImport("Inpout32.dll")> Friend Shared Function IsXP64Bit() As Boolean

    End Function

    <DllImport("Inpout32.dll")> Friend Shared Function DlPortReadPortUchar(ByVal Port As UShort) As Byte

    End Function

    <DllImport("Inpout32.dll")> Friend Shared Sub DlPortWritePortUchar(ByVal Port As UShort, ByVal Data As Byte)

    End Sub

    <DllImport("InpOut32.dll")> Friend Shared Function DlPortReadPortUshort(ByVal Port As UShort) As UShort

    End Function

    <DllImport("InpOut32.dll")> Friend Shared Sub DlPortWritePortUshort(ByVal Port As UShort, ByVal Data As UShort)

    End Sub

    <DllImport("InpOut32.dll")> Friend Shared Function DlPortReadPortUlong(ByVal Port As UShort) As ULong

    End Function

    <DllImport("InpOut32.dll")> Friend Shared Sub DlPortWritePortUlong(ByVal Port As UShort, ByVal Data As ULong)

    End Sub
End Class
