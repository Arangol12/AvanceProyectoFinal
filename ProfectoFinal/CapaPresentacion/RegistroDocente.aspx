<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="RegistroDocente.aspx.cs" Inherits="CapaPresentacion.RegistroDocente" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <style>
      /* Estilos generales */
      .form-container {
          width: 400px;
          margin: 20px auto;
          background-color: #ffd800;
          border: 1px solid #ccc;
          border-radius: 8px;
          padding: 20px;
          box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
      }

      .form-group {
          margin-bottom: 15px;
      }

      label {
          display: block;
          margin-bottom: 5px;
          font-weight: bold;
      }

      .form-control {
          width: 100%;
          padding: 8px;
          border: 1px solid #ccc;
          border-radius: 5px;
      }

      .btn {
          width: 100%;
          padding: 10px;
          border: none;
          border-radius: 5px;
          cursor: pointer;
      }

      .btn-primary {
          background-color: #ff0000;
          color: #fff;
          font-size: 16px;
      }

      .btn-primary:hover {
          background-color: darkblue;
      }

      /* Estilos específicos para el formulario de registro (inicialmente oculto) */
      .register-container {
          display: none;
      }
  </style>

        <div class="row">
        <div class="form-control">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/LoginParaAcceder.aspx">Login</asp:HyperLink>
        </div>
    </div>

    <!-- Formulario de registro -->
    <div class="form-container" id="loginForm">
        <div class="form-group">
            <label for="ddubigeo">Ubigeo</label>
            <div class="row">
                <div class="col-sm-12">
                    <asp:DropDownList ID="ddlDepartamento" runat="server" OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged" AutoPostBack="true" Width="300"  >
                      
                    </asp:DropDownList>
             
                    <asp:DropDownList ID="ddlProvencia" runat="server" OnSelectedIndexChanged= "ddlProvencia_SelectedIndexChanged" AutoPostBack="True" Width="300">
                    
                    </asp:DropDownList>
           
                    <asp:DropDownList ID="ddlDistrito" runat="server" OnSelectedIndexChanged="ddlDistrito_SelectedIndexChanged" AutoPostBack="true" Width="300">
 
                    </asp:DropDownList>
                </div>
           
             


          <div class="form-group">
     <label for="ddSexo">Sexo</label>
       <asp:RadioButtonList ID="cboSexo" runat="server">
      <asp:ListItem Text="Masculino" Value="MASCULINO" />
     <asp:ListItem Text="Femenino" Value="FEMENINO" />
        </asp:RadioButtonList>
          </div>
              <div class="form-group">
              <label for="txtEstadoCivil">Estado Civil</label>
                  <asp:DropDownList ID="cboEsatdoCivil" runat="server">
                      <asp:ListItem>Soltero</asp:ListItem>
                      <asp:ListItem>Casado</asp:ListItem>
                  </asp:DropDownList><br />
                 

                 </div>
             <div class="form-group">
             <label for="txtDireccion">Direccion</label>
           <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
            </div>
              <div class="form-group">
           <label for="txtDiscapacidad">Discapacidad</label>
          <asp:TextBox ID="txtDiscapacidad" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
       </div>
        <div class="form-group">
    <label for="txtDiscripcionDiscapacidad">Discripcion Discapacidad</label>
 <asp:TextBox ID="txtDiscripcionDis" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
</div>
        <div class="form-group">
    <label for="txtTelefono">Telefono</label>
 <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
</div>
        <div class="form-group">
    <label for="txtCelular">Celular</label>
 <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
</div>
        <!-- Resto de campos del formulario... -->
        
        <!-- Campo para la foto con estilo diferente -->
        <div class="form-group">
            <label for="txtFoto">Foto</label>
            <div class="input-group">
                <span class="input-group-addon"><i class="fa fa-camera" aria-hidden="true"></i></span>
                <asp:TextBox ID="txtFoto" runat="server" CssClass="form-control" placeholder="Adjuntar foto"></asp:TextBox>
            </div>
        </div>

              <div class="form-group">
    <label for="txtFechaRegistro">Fecha Registro</label>
 <asp:TextBox ID="txtFechaRegistro" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
</div>
        <div class="form-group">
    <label for="txtFechaModificacion">FechaModificacion</label>
 <asp:TextBox ID="txtFechaModificacion" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
</div>

        <!-- Botón de registro -->
        <div class="form-group">
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Registrar" />
        </div>
    </div>
   


</asp:Content>
