<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrimesChecker.PrimesCheckerWebView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="~/Recources/starz.css" type="text/css" runat="server" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:300" type="text/css" />
    <title></title>
</head>

<!--
This is the HTML page I made using Bootstrap for mobile responsiveness. style file is starz.css where the moving gradient I found on codepen.io.
    Added some of my own and formatter the form.
-->

<body>
    <form id="form1" runat="server">
        <div class="container align-content-center justify-content-center">
            <center>
                <h1>This is a prime number checker!</h1>     
                <br />
                <br />
                <div id="mainborder" class="col-sm border border-primary rounded w-50 p-3 justify-content-center h-75 d-inline-block>">
                    <div class="row justify-content-center">
                        <h3>If it&#39;s a prime number you&#39;ll get a geeky joke! Go on, enter a number:</h3>
                    </div>
                    <br />
                    <div class="row justify-content-center">
                        <div class="col-lg-3 justify-content-center">
                            <asp:TextBox ID="number" runat="server" class="form-control" type="number"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row justify-content-center">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="number"
                            ErrorMessage="You are more likely to get a joke if it's a positive integer!" Display="Dynamic" Font-Bold="True" ForeColor="Blue"></asp:RequiredFieldValidator>
                    </div>
                    <div class="row justify-content-center">
                        <asp:RegularExpressionValidator id="NumberRegex" runat="server"
                        ErrorMessage="You are more likely to get a joke if it's a positive integer!"
                        ValidationExpression="^\d*\.{0,1}\d+$"
                        ControlToValidate="number">
                        </asp:RegularExpressionValidator>
                    </div>
                    <br />
                    <div class="row justify-content-center">    
                        <asp:Button ID="Button1" class="btn btn-primary btn-lg" runat="server" OnClick="Button1_Click" Text="Check if it's prime!" />
                    </div>
                    <br />
                    <div class="row justify-content-center">                
                        <asp:Label ID="result" runat="server"></asp:Label>
                    </div>
                    <br />
                    <div class="row justify-content-center">
                        <div id="jokeborder" class="col- rounded justify-content-center w-75 p-3>">
                            <asp:Label ID="jokeResult" runat="server"></asp:Label>
                         </div>
                    </div>
                    <br />
                    <div class="row justify-content-center">                
                        <asp:Label ID="giflabel" runat="server"></asp:Label>
                    </div>   
                </div>
            </center>
        </div>
    </form>            
</body>
</html>
