<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Epicode_U4_W3_D5_Benchmark._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>

        <div class="row row-cols-1">
            
            <div class="row row-cols-1 row-cols-xs-3 row-cols-md-4 justify-content-center">

                <!-- Repeater -->
                <asp:Repeater ID="RepeaterArticoli" runat="server" ItemType="Epicode_U4_W3_D5_Benchmark.Articolo">
                    <ItemTemplate>

                        <div class="m-1">

                            <div class="card" style="width: 18rem;">
                                <p class="rimasti"><%# Item.Quantita %> rimasti!</p>

                              <img src="../Content/imgs/<%# Item.Foto %>" class="card-img-top" height="150">
                              <div class="card-body">
                                <h5 class="card-title"><%# Item.Nome %></h5>
                                <p class="card-text text-truncate"> <%# Item.Descrizione %> </p>
                                <a href="dettaglioArticolo.aspx?ID=<%#Item.ID %>" class="btn btn-danger">Scopri di più</a>
                              </div>
                            </div>

                        </div>

                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </div>

</asp:Content>

    