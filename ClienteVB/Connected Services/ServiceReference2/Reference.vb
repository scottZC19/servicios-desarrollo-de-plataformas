﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference2
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference2.Calculadora4Soap")>  _
    Public Interface Calculadora4Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function Suma(ByVal a As Double, ByVal b As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function SumaAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function Resta(ByVal a As Double, ByVal b As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function RestaAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function Multiplicacion(ByVal a As Double, ByVal b As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function MultiplicacionAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function Division(ByVal a As Double, ByVal b As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function DivisionAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function Potencia(ByVal a As Double, ByVal b As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function PotenciaAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Raiz", ReplyAction:="*")>  _
        Function Raiz(ByVal a As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Raiz", ReplyAction:="*")>  _
        Function RaizAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Fact", ReplyAction:="*")>  _
        Function Fact(ByVal n As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Fact", ReplyAction:="*")>  _
        Function FactAsync(ByVal n As Integer) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Coseno", ReplyAction:="*")>  _
        Function Coseno(ByVal a As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Coseno", ReplyAction:="*")>  _
        Function CosenoAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Seno", ReplyAction:="*")>  _
        Function Seno(ByVal a As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Seno", ReplyAction:="*")>  _
        Function SenoAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Tangente", ReplyAction:="*")>  _
        Function Tangente(ByVal a As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Tangente", ReplyAction:="*")>  _
        Function TangenteAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface Calculadora4SoapChannel
        Inherits ServiceReference2.Calculadora4Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Calculadora4SoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference2.Calculadora4Soap)
        Implements ServiceReference2.Calculadora4Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Suma(ByVal a As Double, ByVal b As Double) As Double Implements ServiceReference2.Calculadora4Soap.Suma
            Return MyBase.Channel.Suma(a, b)
        End Function
        
        Public Function SumaAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.SumaAsync
            Return MyBase.Channel.SumaAsync(a, b)
        End Function
        
        Public Function Resta(ByVal a As Double, ByVal b As Double) As Double Implements ServiceReference2.Calculadora4Soap.Resta
            Return MyBase.Channel.Resta(a, b)
        End Function
        
        Public Function RestaAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.RestaAsync
            Return MyBase.Channel.RestaAsync(a, b)
        End Function
        
        Public Function Multiplicacion(ByVal a As Double, ByVal b As Double) As Double Implements ServiceReference2.Calculadora4Soap.Multiplicacion
            Return MyBase.Channel.Multiplicacion(a, b)
        End Function
        
        Public Function MultiplicacionAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.MultiplicacionAsync
            Return MyBase.Channel.MultiplicacionAsync(a, b)
        End Function
        
        Public Function Division(ByVal a As Double, ByVal b As Double) As Double Implements ServiceReference2.Calculadora4Soap.Division
            Return MyBase.Channel.Division(a, b)
        End Function
        
        Public Function DivisionAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.DivisionAsync
            Return MyBase.Channel.DivisionAsync(a, b)
        End Function
        
        Public Function Potencia(ByVal a As Double, ByVal b As Double) As Double Implements ServiceReference2.Calculadora4Soap.Potencia
            Return MyBase.Channel.Potencia(a, b)
        End Function
        
        Public Function PotenciaAsync(ByVal a As Double, ByVal b As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.PotenciaAsync
            Return MyBase.Channel.PotenciaAsync(a, b)
        End Function
        
        Public Function Raiz(ByVal a As Double) As Double Implements ServiceReference2.Calculadora4Soap.Raiz
            Return MyBase.Channel.Raiz(a)
        End Function
        
        Public Function RaizAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.RaizAsync
            Return MyBase.Channel.RaizAsync(a)
        End Function
        
        Public Function Fact(ByVal n As Integer) As Double Implements ServiceReference2.Calculadora4Soap.Fact
            Return MyBase.Channel.Fact(n)
        End Function
        
        Public Function FactAsync(ByVal n As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.FactAsync
            Return MyBase.Channel.FactAsync(n)
        End Function
        
        Public Function Coseno(ByVal a As Double) As Double Implements ServiceReference2.Calculadora4Soap.Coseno
            Return MyBase.Channel.Coseno(a)
        End Function
        
        Public Function CosenoAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.CosenoAsync
            Return MyBase.Channel.CosenoAsync(a)
        End Function
        
        Public Function Seno(ByVal a As Double) As Double Implements ServiceReference2.Calculadora4Soap.Seno
            Return MyBase.Channel.Seno(a)
        End Function
        
        Public Function SenoAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.SenoAsync
            Return MyBase.Channel.SenoAsync(a)
        End Function
        
        Public Function Tangente(ByVal a As Double) As Double Implements ServiceReference2.Calculadora4Soap.Tangente
            Return MyBase.Channel.Tangente(a)
        End Function
        
        Public Function TangenteAsync(ByVal a As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference2.Calculadora4Soap.TangenteAsync
            Return MyBase.Channel.TangenteAsync(a)
        End Function
    End Class
End Namespace