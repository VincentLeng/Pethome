  <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeBehind="jiyang.aspx.cs" Inherits="WEB.jiyang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/ZLJxiangqing.css" rel="stylesheet" />
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
                            <td class="auto-style4" style="font-size: 30px; text-align: center;" colspan="2">宠物寄养</td>
                               </tr>
                                <tr>
                                    <td class="auto-style5" style="font-size: 20px; text-align: center;">寄养的地址：
                                        <asp:TextBox ID="TbFosterAdd" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TbFosterAdd" ErrorMessage="！">
                                         </asp:RequiredFieldValidator>
                                    </td>
                                    <td class="auto-style4" style="font-size: 20px; text-align: center;">寄养的时间：
                                        <asp:TextBox ID="TbFosterTime" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TbFosterTime" ErrorMessage="！">
                                         </asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5" style="font-size: 20px; text-align: center;">寄养者电话：
                                        <asp:TextBox ID="TbFosterUserPhone" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TbFosterUserPhone" ErrorMessage="！">
                                         </asp:RequiredFieldValidator>
                                    </td>
                                    <td class="auto-style4" style="font-size: 20px; text-align: center;">宠物的状态：
                                        <asp:TextBox ID="TbFosterStatus" runat="server" Height="30px" Width="200px"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TbFosterStatus" ErrorMessage="！">
                                         </asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                     <td class="auto-style5" style="font-size: 20px; text-align: left;">
                                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;信息的内容：&nbsp;
                                    </td>
                                     <td class="auto-style4" style="font-size: 20px; text-align: center;">图片的信息：
                                         <asp:TextBox ID="TbFosterPetPhoto" runat="server" Height="30px"  Width="200px"></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TbFosterPetPhoto" ErrorMessage="！">
                                          </asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                     <td class="auto-style6" style="font-size: 20px; text-align: center;" colspan="2">
                                         <asp:TextBox ID="TbFosterContent" runat="server" Height="120px"  Width="650px"></asp:TextBox>
                                 
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TbFosterContent" ErrorMessage="！">
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
                               <asp:ListView ID="LvFosterContent" runat="server">
                                    <LayoutTemplate>
                                        <table>
                                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                        </table>
                                    </LayoutTemplate>   	   
                                 <ItemTemplate>      
                              <div id="Box2-2-1">                                
                                    <p><%#Eval("FosterTime")%></p>
				                    <p><%#Eval("FosterContent") %></p>                       
			                        <p><a class="btn" href="jiyangxiangqing.aspx?id=<%# Eval("FosterID")%>">详  情 »</a></p>
                              </div>
                             </ItemTemplate>
                             </asp:ListView>
                          </div>
                             
                    
	            </div>
	        </div>
             
        </div>
     </div>
    <script src="js/jquery-1.8.2.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</asp:Content>
