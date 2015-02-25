Public Class OrderLine

    Private m_Name As String
    Private m_Qty, m_Price As Double

    Public Property name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property qty As String
        Get
            Return m_Qty
        End Get
        Set(value As String)
            m_Qty = value
        End Set
    End Property

    Public Property price As String
        Get
            Return m_Price
        End Get
        Set(value As String)
            m_Price = value
        End Set
    End Property

    Public ReadOnly Property lineTotal As Double
        Get
            Return m_Qty * m_Price
        End Get
    End Property

End Class
