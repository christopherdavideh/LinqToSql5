<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LinqToSql.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:UpdatePanel ID="Udp" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Label ID="lbl_mesaje" runat="server" ForeColor="Green" Visible="false" Text=""></asp:Label>
                    </td>
                <tr>
                    <td></td>
                    <td colspan="2">		
                        <asp:Label ID="lbl_error" runat="server" ForeColor="Red" Visible="false" Text=""></asp:Label>	
                    </td>
                </tr>
            </table>
            <br />
            <div class="form-group has-feedback">
            <asp:TextBox ID="txt_user" runat="server" type="text" class="form-control bg-white shadow-sm" placeholder="Usuario"></asp:TextBox>
            <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
          </div>
          <div class="form-group has-feedback">
            <asp:TextBox ID="txt_pass" runat="server" type="password" class="form-control bg-white shadow-sm" placeholder="Contraseña"></asp:TextBox>
            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
          </div>
          <div class="row">
            <!--<div class="col-xs-8">    
              <div class="checkbox icheck">
                <label>
                  <input type="checkbox"> Remember Me
                </label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>                        
            </div><!-- /.col -->            
          </div>
          <div class="row">
              <div class="col-xs-6" style="padding-top:5px">
                  <asp:LinkButton ID="lnk_button" runat="server" OnClick="lnk_button_Click">Olvidó su contraseña</asp:LinkButton>
              </div><!-- /.col -->
              <div class="col-xs-5">
                  <asp:Button ID="btn_olvido" class="btn btn-warning btn-block btn-flat" runat="server" Text="Recuperar" Visible="false" OnClick="btn_olvido_Click" />
              </div><!-- /.col -->  
          </div>
          <div style="padding-top:10px">
            <asp:Button ID="btn_ingreso" class="btn btn-success btn-lg btn-block py-2" runat="server" Text="Ingresar" OnClick="btn_ingreso_Click" /> 
          </div>
          <div style="padding-top:10px">
            <asp:Button ID="btn_registro" class="btn btn-primary btn-lg btn-block py-2" runat="server" Text="Registrar" Visible="false" OnClick="btn_registro_Click" /> 
          </div>     
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
