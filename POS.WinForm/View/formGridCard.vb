Imports POS.WinForm

Public Class formGridCard
    Implements IGridCardView

    Private _presenter As GridCardPresenter


    Public Sub New()
        InitializeComponent()
        comboFiliale.DisplayMember = "Key"
        comboFiliale.ValueMember = "Value"

        _presenter = New GridCardPresenter(Me)
        _presenter.Init()

    End Sub


    Public Property CodiceFiliale As String Implements IGridCardView.CodiceFiliale
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            lblFiliale.Invoke(Sub()
                                  lblFiliale.Text = value
                              End Sub)
        End Set
    End Property

    Public Property Saldo As String Implements IGridCardView.Saldo
        Get
            Return txtSaldo.Text
        End Get
        Set(value As String)
            txtSaldo.Invoke(Sub()
                                txtSaldo.Text = value
                            End Sub)
        End Set
    End Property

    Public Sub ClearGrid() Implements IGridCardView.ClearGrid

        lstCards.Invoke(Sub()
                            lstCards.Items.Clear()
                        End Sub)

    End Sub

    Public Sub AddGrid(resultRepository As List(Of FidelityCardViewModel)) Implements IGridCardView.AddGrid

        lstCards.Invoke(Sub()

                            For Each item As FidelityCardViewModel In resultRepository

                                Dim lvi As New ListViewItem()
                                lvi.Tag = item
                                lvi.Text = item.CodiceCard
                                lvi.SubItems.Add(item.Saldo)

                                lstCards.Items.Add(lvi)
                            Next

                        End Sub)

    End Sub

    Public Sub SelectedItemList(row As Integer) Implements IGridCardView.SelectedItemList

        lstCards.Invoke(Sub()
                            lstCards.Items(row).Selected = True

                            lstCards.Select()
                        End Sub)

    End Sub

    Public Sub UpdateSaldo(saldo As String) Implements IGridCardView.UpdateSaldo

        If (Not lstCards.SelectedItems Is Nothing) Then

            Dim item As ListViewItem = lstCards.SelectedItems(0)

            item.SubItems(1).Text = saldo

        End If

    End Sub

    Public Sub EnableForm() Implements IGridCardView.EnableForm

        lstCards.SafeInvoke(Sub()
                                lstCards.Enabled = True
                            End Sub)

        GroupEdit.SafeInvoke(Sub()
                                 GroupEdit.Visible = True
                             End Sub)
    End Sub

    Private Sub SetComboBoxData(data As List(Of FidelityFilialeViewModel)) Implements IGridCardView.SetComboBoxData

        comboFiliale.SafeInvoke(Sub()
                                    comboFiliale.DataSource = New BindingSource(data, Nothing)
                                End Sub)

        AddHandler comboFiliale.SelectedIndexChanged, AddressOf OnChenged

    End Sub


    Private Sub OnChenged(sender As Object, e As EventArgs)

        _presenter.SetSelectedFiliale(comboFiliale.SelectedValue.ToString)

    End Sub


    Private Sub ListCardClick(sender As Object, e As EventArgs) Handles lstCards.Click

        Dim card As FidelityCardViewModel = CType(lstCards.SelectedItems(0).Tag, FidelityCardViewModel)

        _presenter.OnClickCard(card)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        _presenter.UpdadteSaldo()

    End Sub
End Class


