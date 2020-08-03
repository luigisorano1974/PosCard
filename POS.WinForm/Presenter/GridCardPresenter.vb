Imports Microsoft.Toolkit.Extensions
Imports POS.Repository
Imports POS.WinForm

Public Class GridCardPresenter

    ReadOnly _view As IGridCardView

    ReadOnly _fidelitiCardRepository As FidelityCardDataAccess

    Private _filialeCorrente As String

    Private _cardCorrente As FidelityCardViewModel

    Private _initialized As Boolean

    Public Sub New(View As IGridCardView)

        _view = View

        _fidelitiCardRepository = New FidelityCardDataAccess()

    End Sub

    Public Sub Init()

        Task.Run(Sub()
                     Dim resultRepository As List(Of FidelityFilialeViewModel) = (From c In _fidelitiCardRepository.GetCodiciFiliale().Result
                                                                                  Select New FidelityFilialeViewModel With
                                                                                      {
                                                                                      .Key = c,
                                                                                      .Value = c
                                                                                      }).ToList()

                     _view.SetComboBoxData(resultRepository)

                     PopolaGriglia(resultRepository.First().Key)

                 End Sub)

    End Sub

    Private Sub PopolaGriglia(codiceFiliale As String)

        _filialeCorrente = codiceFiliale

        _view.ClearGrid()

        Task.Run(Sub()
                     Dim resultRepository As List(Of FidelityCardViewModel) = (From c In _fidelitiCardRepository.GetAllCards(codiceFiliale).Result
                                                                               Select New FidelityCardViewModel With
                                                                                   {
                                                                                   .Id = c.id,
                                                                                   .CodiceCard = c.codicefileity,
                                                                                   .Saldo = c.saldo
                                                                                   }).ToList()

                     OnClickCard(resultRepository.First)

                     _view.AddGrid(resultRepository)

                     _view.SelectedItemList(0)

                     If (Not _initialized) Then _view.EnableForm()

                     _initialized = True

                 End Sub)

    End Sub

    Sub SetSelectedFiliale(filialeSelezionata As String)

        If (_filialeCorrente <> filialeSelezionata) Then

            PopolaGriglia(filialeSelezionata)

        End If

    End Sub

    Sub OnClickCard(card As FidelityCardViewModel)

        _view.Saldo = card.Saldo

        _view.CodiceFiliale = card.CodiceCard

        _cardCorrente = card

    End Sub

    Sub UpdadteSaldo()

        If _view.Saldo.IsDecimal() Then

            _fidelitiCardRepository.UpdateCard(New FidelityModel With {.id = _cardCorrente.Id, .saldo = _view.Saldo})

            _view.UpdateSaldo(_view.Saldo)

        End If

    End Sub

End Class
