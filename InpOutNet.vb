Public Class InpOutNet

    Public Sub Out32(ByVal PortAddress As Short, ByVal Data As Short)
        If IntPtr.Size = 4 Then
            InpOut32.Out32(PortAddress, Data)
        Else
            InpOut64.Out32(PortAddress, Data)
        End If
    End Sub

    Public Function Inp32(ByVal PortAddress As Short) As Short
        If IntPtr.Size = 4 Then
            Return InpOut32.Inp32(PortAddress)
        Else
            Return InpOut64.Inp32(PortAddress)
        End If
    End Function

    Public Function IsInpOutDriverOpen() As Boolean
        If IntPtr.Size = 4 Then
            Return InpOut32.IsInpOutDriverOpen()
        Else
            Return InpOut64.IsInpOutDriverOpen()
        End If
    End Function

    Public Function IsXP64Bit() As Boolean
        If IntPtr.Size = 4 Then
            Return InpOut32.IsXP64Bit
        Else
            Return InpOut64.IsXP64Bit
        End If
    End Function

    Public Function DlPortReadPortUchar(ByVal Port As UShort) As Byte
        If IntPtr.Size = 4 Then
            Return InpOut32.DlPortReadPortUchar(Port)
        Else
            Return InpOut64.DlPortReadPortUchar(Port)
        End If
    End Function

    Public Sub DlPortWritePortUchar(ByVal Port As UShort, ByVal Data As Byte)
        If IntPtr.Size = 4 Then
            InpOut32.DlPortWritePortUchar(Port, Data)
        Else
            InpOut64.DlPortWritePortUchar(Port, Data)
        End If
    End Sub

    Public Function DlPortReadPortUshort(ByVal Port As UShort) As UShort
        If IntPtr.Size = 4 Then
            Return InpOut32.DlPortReadPortUshort(Port)
        Else
            Return InpOut64.DlPortReadPortUshort(Port)
        End If
    End Function

    Public Sub DlPortWritePortUshort(ByVal Port As UShort, ByVal Data As UShort)
        If IntPtr.Size = 4 Then
            InpOut32.DlPortWritePortUshort(Port, Data)
        Else
            InpOut64.DlPortWritePortUshort(Port, Data)
        End If
    End Sub

    Public Function DlPortReadPortUlong(ByVal Port As UShort) As ULong
        If IntPtr.Size = 4 Then
            Return InpOut32.DlPortReadPortUlong(Port)
        Else
            Return InpOut64.DlPortReadPortUlong(Port)
        End If
    End Function

    Public Sub DlPortWritePortUlong(ByVal Port As UShort, ByVal Data As ULong)
        If IntPtr.Size = 4 Then
            InpOut32.DlPortWritePortUlong(Port, Data)
        Else
            InpOut64.DlPortWritePortUlong(Port, Data)
        End If
    End Sub


End Class
