<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeBehind="ShangC.aspx.cs" Inherits="WEB.ShangC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/ShangC.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="Content">
       <div>
            <ul id="myTab" class="nav nav-tabs" style="list-style:none;">
                <li class="active">
                    <a href="#Pets" data-toggle="tab">
                        <asp:LinkButton ID="LinkButton1" runat="server">Pets</asp:LinkButton></a>                     
                </li>
                <li>
                    <a href="#Food" data-toggle="tab" data-cate-id="">
                        <asp:LinkButton ID="LinkButton2" runat="server">Food</asp:LinkButton></a>
                </li>
                <li>
                    <a href="#Cothing" data-toggle="tab">
                        <asp:LinkButton ID="LinkButton3" runat="server">Cothing</asp:LinkButton></a>
                </li>
                <li>
                    <a href="#Toy" data-toggle="tab">
                        <asp:LinkButton ID="LinkButton4" runat="server">Toy</asp:LinkButton></a>  
                </li>               
            </ul>
        </div>     
        <div id="myTabContent" class="tab-content">
                <div class="tab-pane fade in active" id="Pets">
                   <div id="P1">
                        <asp:ListView ID="LvPets" runat="server">
                                    <LayoutTemplate>
                                        <table>
                                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                        </table>
                                    </LayoutTemplate>   	   
                                 <ItemTemplate>      
                                        <div id="P1-1">
                                            <div id="image">
                                                <img src="<%#Eval("ProdPhoto")%>" width="300" height="240"/>
                                            </div>
                                            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("Infomation")%></p>
                                            <p style="text-align:right">￥<%#Eval("Prices")%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
                                        </div>
                                  </ItemTemplate>
                        </asp:ListView>
                   </div>
                </div>
                <div class="tab-pane fade" id="Food">
                    djipq
                </div>
                <div class="tab-pane fade" id="Cothing">
                    这是预订的装备
                </div>
                <div class="tab-pane fade" id="Toy">
                    dwqdjow
                </div>             
            </div>
    </div>

     <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</asp:Content>
