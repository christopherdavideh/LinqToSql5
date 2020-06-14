<%@ Page Title="" Language="C#" MasterPageFile="~/Register.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LinqToSql.Register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
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
                <asp:TextBox ID="txt_nombre" runat="server" type="text" class="form-control bg-white shadow-sm" placeholder="Nombre"></asp:TextBox>
                <span class="glyphicon glyphicon-user form-control-feedback"></span>
              </div>
              <div class="form-group has-feedback">
                <asp:TextBox ID="txt_apellido" runat="server" type="text" class="form-control bg-white shadow-sm" placeholder="Apellido"></asp:TextBox>
                <span class="glyphicon glyphicon-user form-control-feedback"></span>
              </div>
            <div class="form-group has-feedback">
                <asp:TextBox ID="txt_ced" runat="server" type="number" class="form-control bg-white shadow-sm" placeholder="Cedula"></asp:TextBox>
                <span class="glyphicon glyphicon-modal-window form-control-feedback"></span>
              </div>
              <div class="form-group has-feedback">
                <asp:TextBox ID="txt_direc" runat="server" type="text" class="form-control bg-white shadow-sm" placeholder="Direccion"></asp:TextBox>
                <span class="glyphicon glyphicon-map-marker form-control-feedback"></span>
              </div>
            <div class="form-group has-feedback">
                <asp:TextBox ID="txt_telef" runat="server" type="number" class="form-control bg-white shadow-sm" placeholder="Telefono"></asp:TextBox>
                <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
              </div>
              <div class="form-group has-feedback">
                <asp:TextBox ID="txt_pass" runat="server" type="password" class="form-control bg-white shadow-sm" placeholder="Contraseña"></asp:TextBox>
                <span class="glyphicon glyphicon-lock form-control-feedback"></span>
              </div>
            <div class="form-group has-feedback">
                <asp:TextBox ID="txt_user" runat="server" type="text" class="form-control bg-white shadow-sm" placeholder="User"></asp:TextBox>
                <span class="glyphicon glyphicon-user form-control-feedback"></span>
              </div>
              <div class="form-group has-feedback">
                <asp:TextBox ID="txt_email" runat="server" type="email" class="form-control bg-white shadow-sm" placeholder="Email"></asp:TextBox>
                <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
              </div>
              <div style="padding-top:10px">
                <asp:Button ID="btn_guardar" class="btn btn-success btn-lg btn-block py-2" runat="server" Text="Guardar" OnClick="btn_guardar_Click"  /> 
              </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
