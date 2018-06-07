<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeBehind="zhaolingxiangqing.aspx.cs" Inherits="WEB.zhaolingxiangqing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/zhaolingxiangqing.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div id="All">
            <div id="Model">
                <div id="Model-1">
                    <asp:ListView ID="LvText" runat="server">
                            <LayoutTemplate>
                                <table>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                </table>
                            </LayoutTemplate>
                     <ItemTemplate>
                    <div id="Text">
                        <p style="font-size: 20px;">&nbsp;&nbsp; 时间：<%#Eval("Findtime") %></p><br />
                        <p style="font-size: 20px;">&nbsp;&nbsp; 地点：<%#Eval("FindAdd") %></p><br />
                        <p style="font-size: 20px;">&nbsp;&nbsp; 电话：<%#Eval("FindUserPhone") %></p><br />
                        <p style="font-size: 20px;">&nbsp;&nbsp; 状态：<%#Eval("FindStatus") %></p><br />
                        <p style="font-size: 20px;">&nbsp;&nbsp; 内容：</p><br />
                        <p style="font-size: 15px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <%#Eval("FindContent") %></p>
                    </div>
                    <div id="Jianxi"></div>
                <div id="Image">
                    <p><img src="<%#Eval("FindPetPhoto") %>" width="400" height="400"/></p>

                </div>
                          </ItemTemplate>
                     </asp:ListView>
                </div>
                
                
            </div>
     </div>
    
</asp:Content>
