Imports System.Runtime.CompilerServices

Module ExtensionControl
    <Extension()>
    Sub SafeInvoke(ByVal uiElement As Control, ByVal updater As Action)

        If Not uiElement Is Nothing Then

            If uiElement.InvokeRequired Then

                uiElement.Invoke(CType(Sub()
                                           SafeInvoke(uiElement, updater)
                                       End Sub, Action))
            Else

                If uiElement.IsDisposed Then
                    Throw New ObjectDisposedException("Control is already disposed.")
                End If

                updater()

            End If

        End If
    End Sub
End Module