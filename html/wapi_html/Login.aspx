﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="materialize/css/materialize.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
    <script src="materialize/js/materialize.js"></script>
    <style>
        body {
            background-color: #f3e5f5;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col offset-s3  s6 ">
                <div class="card-panel grey lighten-4">
                    <h5 class="black-text" style="text-align: center">Login</h5>
                    <div class="row">
                        <div class="input-field col offset-s3 s6">
                                      <label >Username</label>
                            <input placeholder="Username" id="username" name="username" type="text" />
                  
                        </div>
                    </div>
                    <div class="row">
                        <div class="input-field col offset-s3  s6">
                                    <label >Password</label>
                            <input placeholder="Password" id="password" name="password" type="text" />
                    
                        </div>
                    </div>
                    <div class="row">
                        <div class="input-field col offset-s5  s2">
                            <a class="waves-effect waves-light btn">Login</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script>
        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    username: {

                        required:true
                    },
                    password: {


                        required:true
                    }


                }
            });
        });
</script>
</body>
</html>
