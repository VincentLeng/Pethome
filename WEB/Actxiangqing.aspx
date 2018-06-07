<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeBehind="Actxiangqing.aspx.cs" Inherits="WEB.Actxiangqing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Actxiangqing.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="C">
        <div id="C1">
            <div id="C2">
                <div id="C3">                    
                    <div id="C3-1">
                        <br />
                        <p style="font-size:30px;text-align:center;">活&nbsp;动&nbsp;详&nbsp;情</p>
                        <hr  color="gray" size="6"/>
                    </div>
                    <div id="C3-2"> 
                         <asp:ListView ID="LvActxq" runat="server" >
                                    <LayoutTemplate>
                                        <table>
                                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                        </table>
                                    </LayoutTemplate>
                             <ItemTemplate>
                        <p style="font-size:20px;text-align:center;"><%#Eval("ActName") %></p>  
                        <p style="font-size:14px;text-align:center;"><%#Eval("CreateTime") %>--<%#Eval("EndTime") %></p>
                        <p style="font-size:15px;text-align:center;">管理员&nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("Sort") %></p>
                        <br />
                        <div id="Cont" style="font-size:15px;text-align:left;">
                            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("ActContent") %></p><br />
                            <p style="text-align:center;"><img src="<%#Eval("ActLogo") %>" width="400" height="400"/></p>
                             </ItemTemplate>
                             </asp:ListView>
                        </div> 
                        <hr  color="gray" size="6"/>
                       <%--留言评论区--%>                  
                        <div id="C3-3">
                             <asp:ScriptManager ID="ActScriptManager" runat="server" />
                             <asp:UpdatePanel ID="MessageUpdatePanel" runat="server">
                                 <ContentTemplate>
                                    <h4 class="widget-title" style="margin-bottom: 20px;">评论</h4>
                                    <asp:TextBox ID="txtMessage" runat="server" class="form-control" placeholder="会心谈谈" TextMode="MultiLine"  ValidationGroup="txtMessage" Height="80px" Width="500px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvtxtMessage" runat="server" ControlToValidate="txtMessage" SetFocusOnError="true" ErrorMessage="！"  Display="Dynamic" ValidationGroup="txtMessage"></asp:RequiredFieldValidator>
                                    <br /><br />
                                    <asp:Button ID="btnMessage" runat="server" class="btn btn-info" Text="发布评论"  OnClick="btnMessage_Click" ValidationGroup="txtMessage" Height="35px" Width="100px"/>
                                 </ContentTemplate>
                            </asp:UpdatePanel>
                         </div>  
                        <hr  style="color:gray;size:6"/>
                        <asp:UpdatePanel ID="ReplyUpdatePanel" runat="server">
                                        <ContentTemplate>
                        <asp:ListView ID="MessageListView" runat="server"  OnItemDataBound="lvComments_ItemDataBound">
                                <LayoutTemplate>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                                </LayoutTemplate>
                                <ItemTemplate>
                                 
                        <div id="C3-4">
                           <%-- 对内容的回复--%>                         
                               <hr />
                             <div id="Comments">        
                                  <span><a href="#"><%#Eval("UserName") %>:</a><%#Eval("ComContent") %></span><br /></div>
                             <div id="Comments-time">
                                      <h8 style="color:#696666"><%#Eval("ComTime") %></h8>                             
                              </div>
                            <div id="btnReply">
                                   <asp:LinkButton ID="lkbtnReply" runat="server" OnClick="lkbtnReply_Click" ValidationGroup="lkbtnReply">回复</asp:LinkButton>
                             </div>
                            <asp:Panel ID="ReplyPanel" runat="server" Visible="false">
                                    <div id="Reply_textBox">
                                    <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("ComID") %>' Visible="false" />
                                    <asp:TextBox ID="txtReplyContent" class="" TextMode="MultiLine" runat="server" Height="80px" Width="500px" ValidationGroup="textReply"></asp:TextBox><br />
                                        <asp:RequiredFieldValidator ID="rfvtxtReplyContent" runat="server" ControlToValidate="txtReplyContent" SetFocusOnError="true"  Display="Dynamic" ValidationGroup="textReply">回复不能为空</asp:RequiredFieldValidator>
                                    <asp:LinkButton ID="btnRply" runat="server" Text="发表" OnClick="btnRply_Click" class="btn btn-info"  Height="35px" Width="100px" ValidationGroup="textReply"  BorderColor="#666699" />
                                        <hr  color="gray" size="1"/>
                                    </div>
                            </asp:Panel>
                        </div>            
                        <div id="C3-5">
                            
                             <asp:Repeater ID="ReplyRepeater" runat="server">
                            <ItemTemplate>
                                <hr />
                                <div id="Replytext">
                                    <span>
                                    <div id="Replyer">
                                    <a href="#"><%#Eval("回复人") %>&nbsp 回复 &nbsp</a><a href="#"><%#Eval("被回复人") %>:</a><i><%#Eval("ReplyComContent") %></i></div>
                                    <div id="ReplyTime">
                                        <h8 style="color:#696666"><%#Eval("ReplyComTime") %></h8>
                                    </div>
                                    </span>
                                </div>                                 
                            </ItemTemplate>
                        </asp:Repeater>
                        </div>
                                </ItemTemplate>
                    </asp:ListView> 
                    <div id="Pager">
                   

                    
                    </div>
                                  </ContentTemplate>
                                    </asp:UpdatePanel>  
                    </div>
                </div>
            </div>           
        </div>
        
        
        
   
    </div>
</asp:Content>
