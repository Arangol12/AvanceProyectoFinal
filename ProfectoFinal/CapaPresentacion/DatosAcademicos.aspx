<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="DatosAcademicos.aspx.cs" Inherits="CapaPresentacion.DatosAcademicos" %>
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
    <div class=" form-container">
      
        <div class="row">
            <asp:Label ID="Label4" runat="server" Text="CodigoUsuario"></asp:Label>
            <asp:TextBox ID="txtCodigoUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        
        <div class="row"> 
            <asp:Label ID="Label1" runat="server"   Text="Titulo"></asp:Label>
        <asp:DropDownList ID="cboTituloGrado" runat="server" CssClass="form-control">
            <asp:ListItem>Licenciatura </asp:ListItem>
            <asp:ListItem>Licenciatura</asp:ListItem>
            <asp:ListItem>Maestría</asp:ListItem>
            <asp:ListItem>Doctorado</asp:ListItem>
        </asp:DropDownList>
        </div>
        <div class="row">
            <div class=" row">
            <asp:Label ID="Label2" runat="server" Text="Centro de Estudios"></asp:Label>
                <asp:TextBox ID="txtCentroEstudios" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
        </div>
        <div class="row">
            <asp:Label ID="Label3" runat="server" Text="Fecha Grado Obtenido"></asp:Label>
            <asp:Calendar ID="DtCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>

        </div>

        <div class="row">
            <h4> <b>Subir Titulo</b></h4>
            <asp:FileUpload ID="ofSubir" runat="server" CssClass="form-control" />

        </div> 
        <br />

        <div class="btn"> 
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Agregar" OnClick="Button1_Click" />
        </div>
             </div>
       </asp:Content>
