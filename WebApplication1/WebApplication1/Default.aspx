<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

         <asp:LoginView runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                         <div class="jumbotron">
                        <h1>Quiz App Management</h1>
                        <p class="lead">Please log in in to access the quiz management system</p>
                        <p><a href="Account/Login.aspx" class="btn btn-primary btn-lg">Log in &raquo;</a></p>
                        </div>
                        </AnonymousTemplate>
                        <LoggedInTemplate>
                           <h2>Import Student</h2>
                            <form action="http://www.cs.tut.fi/cgi-bin/run/~jkorpela/echo.cgi"
                            enctype="multipart/form-data" method="post">
                          
                            <p style="float:left;">
                           
                            <input  type="file" name="datafile" size="40">
                            </p>
                            <div style="float:left;">
                            <input type="submit" value="Upload">
                            </div>
                                <div style="clear:both;">
                            </form>
                            <br />
                            <br />
                            <br />
                            <hr />
                               <h2>Import Lecturer</h2>
                            <form action="http://www.cs.tut.fi/cgi-bin/run/~jkorpela/echo.cgi"
                            enctype="multipart/form-data" method="post">
                          
                            <p style="float:left;">
                           
                            <input  type="file" name="datafile" size="40">
                            </p>
                            <div style="float:left;">
                            <input type="submit" value="Upload">
                            </div>
                                <div style="clear:both;">
                            </form>
                                <br />
                            <br />
                            <br />
                            <hr />
                               <h2>Import Unit</h2>
                            <form action="http://www.cs.tut.fi/cgi-bin/run/~jkorpela/echo.cgi"
                            enctype="multipart/form-data" method="post">
                          
                            <p style="float:left;">
                           
                            <input  type="file" name="datafile" size="40">
                            </p>
                            <div style="float:left;">
                            <input type="submit" value="Upload">
                            </div>
                                <div style="clear:both;">
                            </form>
                            <br />
                            <br />
                            <br />
                            
                        </LoggedInTemplate>
                    </asp:LoginView>



</asp:Content>
