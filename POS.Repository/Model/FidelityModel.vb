
Imports System.ComponentModel.DataAnnotations
Imports Google.Cloud.Firestore

<FirestoreData>
Public Class FidelityModel

    <Required>
    <FirestoreProperty>
    Property id As String
    <Required>
    <FirestoreProperty>
    Property codicefileity As String
    <Required>
    <FirestoreProperty>
    Property codicefiliale As String
    <Required>
    <FirestoreProperty>
    Property saldo As Double


End Class
