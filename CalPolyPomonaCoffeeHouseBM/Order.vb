Public Class Order

    Private m_ID, m_Server, m_OrderDate
    Private m_OrderLines As New ArrayList
    Private Const taxPercent = 0.0775

    Public Sub addLine(ByVal line As OrderLine)
        m_OrderLines.Add(line)
    End Sub

    Public Function getLine(ByVal index As Integer) As OrderLine
        Return m_OrderLines(index)
    End Function


    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Public Property server As String
        Get
            Return m_Server
        End Get
        Set(value As String)
            m_Server = value
        End Set
    End Property

    Public Property orderDate As String
        Get
            Return m_OrderDate
        End Get
        Set(value As String)
            m_OrderDate = value
        End Set
    End Property


    Public ReadOnly Property total As Double
        Get
            Dim myTotal As Double = 0
            For Each orderline In m_OrderLines
                myTotal += orderline.lineTotal
            Next orderline

            Return myTotal
        End Get
    End Property

    Public ReadOnly Property tax As Double
        Get
            Return total * taxPercent
        End Get
    End Property

    Public ReadOnly Property grandTotal As Double
        Get
            Return total + tax
        End Get
    End Property
End Class
