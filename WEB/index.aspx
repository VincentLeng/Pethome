<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEB.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/shouye.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="PageBody">
          <%-- 轮播图--%>
            <div id="Box1">
                <div id="Box1-1" >
                    <img src="images/bg.png" height="710" width="200"  />
                </div>
                <div id="Box1-2">
                    <img src="images/bg.png" height="710" />
                </div>
                <div id="Box1-3">
                    <div id="Box1-3-1">
                        <img src="images/02.png" width="250" height="100"  />
                    </div>
                    <div id="Box1-3-2">
                         <script type="text/javascript"> 
                              var curIndex = 0; 
                              var timeInterval = 2500; 
                              var arr = new Array(); 
                              arr[0] = "images/1.jpg"; 
                              arr[1] = "images/2.jpg"; 
                              arr[2] = "images/3.jpg"; 
                              arr[3] = "images/4.jpg"; 
 
                              setInterval(changeImg,timeInterval); 
                              function changeImg() { 
                               var obj = document.getElementById("obj"); 
                               if (curIndex == arr.length-1) { 
                                curIndex = 0; 
                               } else { 
                                curIndex += 1; 
                                 } 
                               obj.src = arr[curIndex]; 
                              } 
                             </script> 
                             <!-- <script language="javascript"> 
                              setInterval(test,10000); 
                              var array = new Array(); 
                              var index = 0; 
                              var array = new Array("images/1.jpg","images/2.jpg","images/3.jpg","images/4.jpg"); 
                              function test() { 
                               var myimg=document.getElementById("imgs"); 
                               if(index==array.length-1) 
                               { index=0; }else{ index++; } 
                               myimg.src=array[index]; 
                              } 
                             </script> -->
                              <img id = "obj" src = "images/1.jpg" width="1000" height="500" border = 0 /> 
                    </div>
                    <div id="Box1-3-3">
                        <h6 style="color:palevioletred"><a href="#"><font face="华文楷体" size="20">Pet   Home</font></a></h6>
                    </div>
                </div>         
            </div>
          <%--宠物商城--%>
            <div id="Box2">
                <div id="Box2-1">
                    <h6 style="color:palevioletred"><a href="#"><font face="华文楷体" size="30">OUR-SHOPPING MALL</font></a></h6>
                    <marquee behavior="alternate">
                        <h6 style="color:palevioletred"><a href="#"><font face="华文楷体" size="5" color="red">Every  pet  is  an  angel  given  to  us  by  nature</font></a></h6></marquee>
                </div>
                 <asp:ListView ID="ListView1" runat="server">
                            <LayoutTemplate>
                                <table>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                </table>
                            </LayoutTemplate>
                     <ItemTemplate>
                <div id="Box2-2">
                    
                    <div id="Box2-2-1">
                        <div id="Box2-2-1-1">
                            <a href="#"><img src="<%#Eval("image") %>" /></a></div>
                        <div id="Box2-2-1-2">
                           </div>
                        <div id="Box2-2-1-3">
                            <h3><font face="黑体" size="25"> <a href="#"><%#Eval("Name") %></a></font></h3>
                            <br />
                            <br />
							<p><font face="黑体" size="3" color="red"></font> <%#Eval("Content") %></p><br /><br /><br />
							<p>
                                <asp:Button ID="Button1" runat="server" Text="More"  Height="31px" Width="60px" BackColor="#D9534F" ForeColor="White"  /></p>

                        </div>
                    </div>
                    </ItemTemplate>
                     </asp:ListView>
              
                </div>                                
          <%--失物招领--%>
            <div id="Box3">
                <div id="Box3-1">
                </div>
                <div id="Box3-2">
                     <div id="Box3-2-1">
                         <br />
                         <h4><font face="MV Boli" size="30" color="red"><a href="#">Pets,Help</a></font></h4>
                     </div>
                    <div id="Box3-2-10">
                         <div id="Box3-2-2">
                           <asp:ListView ID="ListView2" runat="server">
                            <LayoutTemplate>
                                <table>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                </table>
                            </LayoutTemplate>
                     <ItemTemplate>
                         <p><font face="微软雅黑" size="4" color="red"><a href="zhaoling.aspx">&nbsp;&nbsp;宠物招领：</a></font></p>
                             <p><font face="微软雅黑" size="2" color="black">发现地点:<%#Eval("FindAdd") %></p>
                             <p><font face="微软雅黑" size="2" color="black">发现时间:<%#Eval("FindTime") %></p>
                             <p><font face="微软雅黑" size="2" color="black">发现者电话：<%#Eval("FindUserPhone") %></p>
                             <p><font face="微软雅黑" size="2" color="black">信息内容：<%#Eval("FindContent") %></p>
                             <p><font face="微软雅黑" size="2" color="black">信息状态：<%#Eval("FindStatus") %></p>
                             <p><font face="微软雅黑" size="2" color="black">宠物图片：</p>
                             <p1><img src="<%#Eval("FindPetPhoto") %>" height="160" width="160" /></p1>
                          </ItemTemplate>
                     </asp:ListView>
                     </div>
                    <div id="Box3-2-3">
                          <asp:ListView ID="ListView3" runat="server">
                            <LayoutTemplate>
                                <table>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                </table>
                            </LayoutTemplate>
                     <ItemTemplate>
                         <p><font face="微软雅黑" size="4" color="red"><a href="ZhaoHui.aspx"> &nbsp;&nbsp;宠物找回： </a></font></p>
                             <p><font face="微软雅黑" size="2" color="black">丢失地点:<%#Eval("FoundLostAdd") %></p>
                             <p><font face="微软雅黑" size="2" color="black">丢失时间:<%#Eval("FoundLostTime") %></p>
                             <p><font face="微软雅黑" size="2" color="black">丢失者电话：<%#Eval("FoundUserPhone") %></p>
                             <p><font face="微软雅黑" size="2" color="black">信息内容：<%#Eval("FoundContent") %></p>
                             <p><font face="微软雅黑" size="2" color="black">信息状态：<%#Eval("FoundStatus") %></p>
                             <p><font face="微软雅黑" size="2" color="black">宠物图片：</p>
                             <p><img src="<%#Eval("FoundPetPhoto") %>" height="160" width="160"  /></p>
                           </ItemTemplate>
                     </asp:ListView>
                    </div>
                    <div id="Box3-2-4">
                         <asp:ListView ID="ListView4" runat="server">
                            <LayoutTemplate>
                                <table>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                </table>
                            </LayoutTemplate>
                     <ItemTemplate>
                         <p><font face="微软雅黑" size="4" color="red"><a href="jiyang.aspx">&nbsp;&nbsp;宠物寄养：</a></font></p>
                             <p><font face="微软雅黑" size="2" color="black">寄养地点:<%#Eval("FosterAdd") %></p>
                             <p><font face="微软雅黑" size="2" color="black">寄养时间:<%#Eval("FosterTime") %></p>
                             <p><font face="微软雅黑" size="2" color="black">寄养者电话：<%#Eval("FosterUserPhone") %></p>
                             <p><font face="微软雅黑" size="2" color="black">信息内容：<%#Eval("FosterContent") %></p>
                             <p><font face="微软雅黑" size="2" color="black">信息状态：<%#Eval("FosterStatus") %></p>
                             <p><font face="微软雅黑" size="2" color="black">宠物图片：</p>
                             <p><img src="<%#Eval("FosterPetPhoto") %>"  height="160" width="160" /></p>
                          </ItemTemplate>
                     </asp:ListView>
                    </div>
                </div>
                    </div>
                    
                <div id="Box3-3">
                    <div id="img1">
                        <a href="wwwhttp://im.qq.com/pcqq/"><img src="images/QQ.png" /></a></div>
                    <div id="img2">
                         <a href="wwwhttp://https://weibo.com/"><img src="images/weibo.png" /></a>
                    </div>
                    <div id="img3">
                        <a href="wwwhttp://im.qq.com/pcqq/"> <img src="images/weixin.png" /></a>
                    </div>
                    <div id="img4">
                       <a href="https://qzone.qq.com/">
                           <img src="images/QQkongjian.png" /> </a></div>
                </div>
            </div>
          <%--论坛--%>
            <div id="Box4">
              <div id="Box4-1">
                 
              </div>
              <div id="Box4-2">
                  <p><font face="MV Boli" size="30"><a href="#">Pet  BBS</a></font></p>
              </div>
              <div id="Box4-2-1">
                  <p>
                     
                      <font face="微软雅黑" size="6"><a href="#">About</a></font></p><br />
                  <p>
                       <font face="微软雅黑" size="6"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#">Make  friends</a></font> </p>
                  <br />
                  <p>
                      <font face="微软雅黑" size="6"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <a href="#">Communication</a></font></p><br />
                  <p>
                       <font face="微软雅黑" size="6"><a href="#">Share</a></font></p><br />

              </div>
              <div id="Box4-2-2">
                  <font face="微软雅黑" size="6"><a href="#">Join us</a></font></p>
              </div>
          </div>
        </div>
   
</asp:Content>
