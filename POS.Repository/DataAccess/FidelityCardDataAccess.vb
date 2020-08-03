Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Threading.Tasks
Imports Google.Cloud.Firestore
Imports Newtonsoft.Json

Public Class FidelityCardDataAccess

    ReadOnly firestoreDb As FirestoreDb

    ReadOnly db As String

    Public Sub New()

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory

        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path + "\fidelity-1cbeb-9fb883dc7f7b.json")

        firestoreDb = FirestoreDb.Create("fidelity-37306")

        db = "cards"

    End Sub


    Public Async Function FirstCodiciFiliale() As Task(Of FidelityModel)

        Dim card As FidelityModel

        Dim allCards As Query = firestoreDb.Collection(db)

        Dim allStudentsQuerySnapshot As QuerySnapshot = Await allCards.GetSnapshotAsync()

        card = allStudentsQuerySnapshot.Documents.First.ConvertTo(Of FidelityModel)()

        Return card

    End Function

    Public Async Function GetCodiciFiliale() As Task(Of HashSet(Of String))

        Try

            Dim ListaCard = New HashSet(Of String)

            Dim collection As Query = firestoreDb.Collection(db)

            Dim querySnapShot As QuerySnapshot = Await collection.GetSnapshotAsync()

            For Each documentSnapshot As DocumentSnapshot In querySnapShot.Documents
                If documentSnapshot.Exists Then
                    ListaCard.Add(documentSnapshot.ConvertTo(Of FidelityModel)().codicefiliale)
                End If
            Next

            Return ListaCard

        Catch ex As Exception
            'TODO: Implementare gestione degli errori
            Throw
        End Try

    End Function

    Public Async Function GetAllCards(codiceFiliale As String) As Task(Of List(Of FidelityModel))

        Try

            Dim ListaCard = New List(Of FidelityModel)()

            Dim item As FidelityModel

            Dim collection As Query = firestoreDb.Collection(db).WhereEqualTo("codicefiliale", codiceFiliale)

            Dim querySnapShot As QuerySnapshot = Await collection.GetSnapshotAsync()

            For Each documentSnapshot As DocumentSnapshot In querySnapShot.Documents

                If documentSnapshot.Exists Then

                    item = documentSnapshot.ConvertTo(Of FidelityModel)

                    item.id = documentSnapshot.Id


                    ListaCard.Add(item)

                End If

            Next

            Dim sortedEmployeeList As List(Of FidelityModel) = ListaCard.OrderBy(Function(x) x.codicefileity).ToList()

            Return sortedEmployeeList

        Catch ex As Exception
            'TODO: Implementare gestione degli errori
            Throw
        End Try
    End Function


    Public Async Sub UpdateCard(card As FidelityModel)

        Try

            Dim docref As DocumentReference = firestoreDb.Collection(db).Document(card.id)

            Dim json = JsonConvert.SerializeObject(card)

            Dim newSaldo = New Dictionary(Of String, Object) From {{"saldo", card.saldo}}

            Await docref.UpdateAsync(newSaldo)

        Catch ex As Exception
            'TODO: Implementare gestione degli errori
            Throw
        End Try

    End Sub

End Class
