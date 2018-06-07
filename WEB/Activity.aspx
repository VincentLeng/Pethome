<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="WEB.Activity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Activity.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="C"><%--第一层--%>
        <div id="C1"><%--第二层--%>
            <div id="C2"><%--第三层--%>
                <div id="C3"><%--第四层--%>                 
                    <div id="C3-1">
                        <br />
                        <p style="font-size:30px;">最&nbsp;新&nbsp;活&nbsp;动</p>
                        <hr  color="gray" size="6"/>
                    </div>
                    <div id="C3-2">
                        <asp:ListView ID="LvAct" runat="server">
                                    <LayoutTemplate>
                                        <table>
                                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                        </table>
                                    </LayoutTemplate>
                             <ItemTemplate>
                        <div id="C3-2-1" >                   
                            <p style="font-size:17px;font-style:normal;">
                                <img src="<%#Eval("ActLogo")%> "/>
                                <a  href="Actxiangqing.aspx?id=<%# Eval("ActID")%>"><%#Eval("ActName")%></a></p><%--ID传递--%>
                            <p style="text-align:right;font-size:12px;font-style:normal;"><%#Eval("CreateTime")%>--<%#Eval("EndTime")%></p>
                        </div>
                                  </ItemTemplate>
                             </asp:ListView>
                     <%--   <div id="C3-2-2">
                        </div>
                        <div id="C3-2-3"></div>
                        <div id="C3-2-4"></div>
                        <div id="C3-2-5"></div>
                        <div id="C3-2-6"></div>
                        <div id="C3-2-7"></div>
                        <div id="C3-2-8"></div>
                        <div id="C3-2-9"></div>
                        <div id="C3-2-10"></div>
                        <div id="C3-2-11"></div>--%>
                        <div id="C3-2-12"><br />
                            <p style="font-size:20px;">更&nbsp;多&nbsp;活&nbsp;动&nbsp;；敬&nbsp;请&nbsp;期&nbsp;待</p>
                        </div>
                    </div>
                </div>
            </div>           
        </div>
        
        
        
    </div>
</asp:Content>
