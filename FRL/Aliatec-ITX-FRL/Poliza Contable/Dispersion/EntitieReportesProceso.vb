Imports Intelexion.Framework.Model

Namespace EntitiesITX

    Public Class ReportesProceso

        Inherits EntityObject

        Private _IdRazonSocial As Integer
        Private _idPersona As Integer
        Private _IdEmpleado As String
        Private _Empleados As String
        Private _IdTipoNominaAsig As String
        Private _IdTipoNominaProc As String
        Private _Anio As Int16
        Private _Periodo As Byte
        Private _AnioDesde As Int16
        Private _PeriodoDesde As Byte
        Private _AnioHasta As Int16
        Private _PeriodoHasta As Byte
        Private _mensajeRecibo As String
        Private _tipoArchivo As Int16
        Private _numeroRegistros As Int16
        Private _claveModulo As String
        Private _claveOrden As String
        Private _portal As Int16
        Private _IdLugarPago As String
        Private _IdCentroCosto As String
        'agregado para "Reportes del Proceso de Nómina - TIPO"
        Private _FechaInicio As DateTime
        Private _FechaFin As DateTime
        Private _valor As String
        Private _AnioPeriodo As Int16
        Private _diasProporcion As Int16

        Private _numeroCliente As String
        Private _fechaPago As DateTime
        Private _claveDescuento As String
        Private _importe As Decimal
        Private _numeroProceso As String
        Private _periodoPago As String

        Private _folioDesde As Integer
        Private _folioHasta As Integer

        Private _Concepto As String
        Private _UID As String
        Private _LID As String
        Private _idAccion As Integer

        Public Sub New()
            _IdRazonSocial = 0
            _idPersona = 0
            _IdEmpleado = ""
            _Empleados = ""
            _IdTipoNominaAsig = ""
            _IdTipoNominaProc = ""
            _Anio = 0
            _Periodo = 0
            _AnioDesde = 0
            _PeriodoDesde = 0
            _AnioHasta = 0
            _PeriodoHasta = 0
            _numeroRegistros = 0
            _mensajeRecibo = ""
            _tipoArchivo = 0
            _claveModulo = ""
            _claveOrden = ""
            _portal = 0
            _IdLugarPago = ""
            _IdCentroCosto = ""
            _FechaInicio = Nothing
            _FechaFin = Nothing
            _valor = ""
            _AnioPeriodo = 0
            _diasProporcion = 0
            _numeroCliente = ""
            _fechaPago = Nothing
            _claveDescuento = ""
            _importe = 0
            _numeroProceso = ""
            _periodoPago = ""
            _folioDesde = 0
            _folioDesde = 0
            _Concepto = ""
            _UID = ""
            _LID = ""
            _idAccion = 0
        End Sub

        Public Property IdRazonSocial() As Integer
            Get
                Return _IdRazonSocial
            End Get
            Set(ByVal Value As Integer)
                _IdRazonSocial = Value
            End Set
        End Property

        Public Property idPersona() As Integer
            Get
                Return _idPersona
            End Get
            Set(ByVal Value As Integer)
                _idPersona = Value
            End Set
        End Property

        Public Property IdEmpleado() As String
            Get
                Return _IdEmpleado
            End Get
            Set(ByVal Value As String)
                _IdEmpleado = Value
            End Set
        End Property

        Public Property Empleados() As String
            Get
                Return _Empleados
            End Get
            Set(ByVal Value As String)
                _Empleados = Value
            End Set
        End Property

        Public Property IdTipoNominaAsig() As String
            Get
                Return _IdTipoNominaAsig
            End Get
            Set(ByVal Value As String)
                _IdTipoNominaAsig = Value
            End Set
        End Property

        Public Property IdTipoNominaProc() As String
            Get
                Return _IdTipoNominaProc
            End Get
            Set(ByVal Value As String)
                _IdTipoNominaProc = Value
            End Set
        End Property

        Public Property Anio() As Int16
            Get
                Return _Anio
            End Get
            Set(ByVal Value As Int16)
                _Anio = Value
            End Set
        End Property

        Public Property AnioDesde() As Int16
            Get
                Return _AnioDesde
            End Get
            Set(ByVal Value As Int16)
                _AnioDesde = Value
            End Set
        End Property

        Public Property AnioHasta() As Int16
            Get
                Return _AnioHasta
            End Get
            Set(ByVal Value As Int16)
                _AnioHasta = Value
            End Set
        End Property
        Public Property numeroRegistros() As Int16
            Get
                Return _numeroRegistros
            End Get
            Set(ByVal Value As Int16)
                _numeroRegistros = Value
            End Set
        End Property

        Public Property Periodo() As Byte
            Get
                Return _Periodo
            End Get
            Set(ByVal Value As Byte)
                _Periodo = Value
            End Set
        End Property

        Public Property PeriodoDesde() As Byte
            Get
                Return _PeriodoDesde
            End Get
            Set(ByVal Value As Byte)
                _PeriodoDesde = Value
            End Set
        End Property

        Public Property PeriodoHasta() As Byte
            Get
                Return _PeriodoHasta
            End Get
            Set(ByVal Value As Byte)
                _PeriodoHasta = Value
            End Set
        End Property

        Public Property mensajeRecibo() As String
            Get
                Return _mensajeRecibo
            End Get
            Set(ByVal Value As String)
                _mensajeRecibo = Value
            End Set
        End Property

        Public Property tipoArchivo() As Int16
            Get
                Return _tipoArchivo
            End Get
            Set(ByVal Value As Int16)
                _tipoArchivo = Value
            End Set
        End Property

        Public Property claveModulo() As String
            Get
                Return _claveModulo
            End Get
            Set(ByVal Value As String)
                _claveModulo = Value
            End Set
        End Property

        Public Property claveOrden() As String
            Get
                Return _claveOrden
            End Get
            Set(ByVal Value As String)
                _claveOrden = Value
            End Set
        End Property

        Public Property portal() As Int16
            Get
                Return _portal
            End Get
            Set(ByVal Value As Int16)
                _portal = Value
            End Set
        End Property

        Public Property IdLugarPago() As String
            Get
                Return _IdLugarPago
            End Get
            Set(ByVal Value As String)
                _IdLugarPago = Value
            End Set
        End Property

        Public Property IdCentroCosto() As String
            Get
                Return _IdCentroCosto
            End Get
            Set(ByVal Value As String)
                _IdCentroCosto = Value
            End Set
        End Property
        Public Property FechaInicio() As DateTime
            Get
                Return _FechaInicio
            End Get
            Set(ByVal Value As DateTime)
                _FechaInicio = Value
            End Set
        End Property

        Public Property FechaFin() As DateTime
            Get
                Return _FechaFin
            End Get
            Set(ByVal Value As DateTime)
                _FechaFin = Value
            End Set
        End Property
        Public Property valor() As String
            Get
                Return _valor
            End Get
            Set(ByVal Value As String)
                _valor = Value
            End Set
        End Property
        Public Property AnioPeriodo() As Int16
            Get
                Return _AnioPeriodo
            End Get
            Set(ByVal Value As Int16)
                _AnioPeriodo = Value
            End Set
        End Property

        Public Property diasProporcion() As Int16
            Get
                Return _diasProporcion
            End Get
            Set(ByVal Value As Int16)
                _diasProporcion = Value
            End Set
        End Property

        Public Property numeroCliente() As String
            Get
                Return _numeroCliente
            End Get
            Set(ByVal Value As String)
                _numeroCliente = Value
            End Set
        End Property

        Public Property fechaPago() As DateTime
            Get
                Return _fechaPago
            End Get
            Set(ByVal Value As DateTime)
                _fechaPago = Value
            End Set
        End Property

        Public Property claveDescuento() As String
            Get
                Return _claveDescuento
            End Get
            Set(ByVal Value As String)
                _claveDescuento = Value
            End Set
        End Property

        Public Property importe() As Decimal
            Get
                Return _importe
            End Get
            Set(ByVal Value As Decimal)
                _importe = Value
            End Set
        End Property

        Public Property numeroProceso() As String
            Get
                Return _numeroProceso
            End Get
            Set(ByVal Value As String)
                _numeroProceso = Value
            End Set
        End Property

        Public Property periodoPago() As String
            Get
                Return _periodoPago
            End Get
            Set(ByVal Value As String)
                _periodoPago = Value
            End Set
        End Property

        Public Property Concepto() As String
            Get
                Return _Concepto
            End Get
            Set(ByVal Value As String)
                _Concepto = Value
            End Set
        End Property

        Public Property folioDesde() As Integer
            Set(ByVal value As Integer)
                _folioDesde = value
            End Set
            Get
                Return _folioDesde
            End Get
        End Property

        Public Property folioHasta() As Integer
            Set(ByVal value As Integer)
                _folioHasta = value
            End Set
            Get
                Return _folioHasta
            End Get
        End Property

        Public Property UID() As String
            Get
                Return _UID
            End Get
            Set(ByVal Value As String)
                _UID = Value
            End Set
        End Property

        Public Property LID() As String
            Get
                Return _LID
            End Get
            Set(ByVal Value As String)
                _LID = Value
            End Set

        End Property

        Public Property idAccion() As Integer
            Set(ByVal value As Integer)
                _idAccion = value
            End Set
            Get
                Return _idAccion
            End Get
        End Property

    End Class

End Namespace



