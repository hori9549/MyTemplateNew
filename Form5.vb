Public Class frm継承_6
    Class baseClass
        Public Overridable Sub testMethod()
            MsgBox("Base class string")
        End Sub
        Public Sub useMe()
            ' The following call uses the calling class's method, even if
            ' that method is an override.
            Me.testMethod()
        End Sub
        Public Sub useMyClass()
            ' The following call uses this instance's method and not any
            ' override.
            MyClass.testMethod()
        End Sub
    End Class
    Class derivedClass : Inherits baseClass
        Public Overrides Sub testMethod()
            MsgBox("Derived class string")
        End Sub
    End Class
    Class testClasses
        Sub startHere()
            Dim testObj As derivedClass = New derivedClass()
            ' The following call displays "Derived class string".
            testObj.useMe()
            ' The following call displays "Base class string".
            testObj.useMyClass()
        End Sub
    End Class
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tc As New testClasses
        tc.startHere()
    End Sub
End Class