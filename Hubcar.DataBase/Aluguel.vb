'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Aluguel
    Public Property Id As Integer
    Public Property DataRetirada As Date
    Public Property DataEntrega As Nullable(Of Date)
    Public Property LocalRetirada As String
    Public Property CarroId As Nullable(Of Integer)
    Public Property AvaliacaoId As Nullable(Of Integer)

    Public Overridable Property Avaliacao As Avaliacao
    Public Overridable Property Carro As Carro

End Class
