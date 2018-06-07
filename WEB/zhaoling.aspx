<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeBehind="zhaoling.aspx.cs" Inherits="WEB.zhaoling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/ZLJxiangqing.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 114px;
            border: 2px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style4 {
            height: 50px;
        }
        .auto-style5 {
            height: 50px;
            width: 472px;
        }
        .auto-style6 {
            height: 150px;
        }
        .auto-style7 {
            height: 90px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
	<div class="row clearfix">
		<div class="col-md-12 column">
			<div class="jumbotron">
                <div id="Text">

                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style4" style="font-size: 30px; text-align: center;" colspan="2">宠物招领</td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-size: 20px; text-align: center;">发现的地址：
                                <asp:TextBox ID="TbFindAdd" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TbFindAdd" ErrorMessage="！">
                                 </asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style4" style="font-size: 20px; text-align: center;">发现的时间：
                                <asp:TextBox ID="TbFindTime" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TbFindTime" ErrorMessage="！">
                                 </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-size: 20px; text-align: center;">发现者电话：
                                <asp:TextBox ID="TbFindUserPhone" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TbFindUserPhone" ErrorMessage="！">
                                 </asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style4" style="font-size: 20px; text-align: center;">宠物的状态：
                                <asp:TextBox ID="TbFindStatus" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TbFindStatus" ErrorMessage="！">
                                 </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                             <td class="auto-style5" style="font-size: 20px; text-align: left;">
                                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;信息的内容：&nbsp;
                            </td>
                             <td class="auto-style4" style="font-size: 20px; text-align: center;">图片的信息：
                                 <asp:TextBox ID="TbFindPetPhoto" runat="server" Height="30px"  Width="200px"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TbFindPetPhoto" ErrorMessage="！">
                                  </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                             <td class="auto-style6" style="font-size: 20px; text-align: center;" colspan="2">
                                 <asp:TextBox ID="TbFindContent" runat="server" Height="120px"  Width="650px"></asp:TextBox>
                                 
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TbFindContent" ErrorMessage="！">
                                  </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                             <td class="auto-style7" style="font-size: 20px; text-align: center;" colspan="2">
                                 <asp:Button ID="btnSubmit" runat="server" Height="40px" Text="提交" Width="120px" OnClick="btnSubmit_Click"/>
                            </td>
                        </tr>
                        </table>

                </div>
			
			</div>
			
		</div>
	</div>
	<div class="row clearfix">
        
		          <div id="Box1">
                  <div id="Box2">
                          <div id="Box2-1">
                          <h2>
				          招领信息:
			              </h2>     
                          </div>            		         
                          <div id="Box2-2">
                               <asp:ListView ID="LvFindContent" runat="server">
                                    <LayoutTemplate>
                                        <table>
                                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                        </table>
                                    </LayoutTemplate>
                             <ItemTemplate>
                              <div id="Box2-2-1">                                
                                    <p><%#Eval("FindTime")%></p>
				                    <p><%#Eval("FindContent") %></p>                       
			                        <p><a class="btn" href="zhaolingxiangqing.aspx?id=<%# Eval("FindID")%>">详  情 »</a></p>
                              </div>
                           
                            </ItemTemplate>
                             </asp:ListView>
                          </div>
                           
                    
	            </div>
	        </div>
              
     <%--   <asp:ListView ID="LvFindContent" runat="server">
                            <LayoutTemplate>
                                <table>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                </table>
                            </LayoutTemplate>
             <ItemTemplate>
		<div class="col-md-4 column">
			<h2>
				招领信息:
			</h2>
         
			<p>
                <p><%#Eval("FindTime")%></p>
				<p><%#Eval("FindContent") %></p>
			</p>
                           
			<p>
				 <a class="btn" href="zhaolingxiangqing.aspx?id=<%# Eval("FindID")%>">详  情 »</a>
			</p>
                 
		</div>
             </ItemTemplate>
                     </asp:ListView>--%>
		<%--<div class="col-md-4 column">
			<h2>
				招领信息2
			</h2>
			<p>
				Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.
			</p>
			<p>
				 <a class="btn" href="#">View details »</a>
			</p>
		</div>
		<div class="col-md-4 column">
			<h2>
				招领信息3
			</h2>
			<p>
				Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.
			</p>
			<p>
				 <a class="btn" href="#">View details »</a>
			</p>
		</div>--%>
	</div>
</div>
     
    <script src="js/jquery-1.8.2.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</asp:Content>
