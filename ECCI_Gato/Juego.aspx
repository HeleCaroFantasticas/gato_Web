<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Juego.aspx.cs" Inherits="ECCI_Gato.Juego" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
		<script src="/js/jquery.min.js"></script>
		<script src="/js/skel.min.js"></script>
		<script src="/js/skel-layers.min.js"></script>
		<script src="/js/init.js"></script>
		<script src="/js/smoothscroll.min.js"></script>
		<style type="text/css">
<!--
table.tic td {
	border: 1px solid #333 !important;
	width: 51px;
	height: 51px;
	vertical-align: middle;
	text-align: center;
	font-size: 25pt;
	font-family: Arial;
}
table { margin-bottom: 10px; }
input.field {
	border: 0;
	background-color: #fff;
	color: #fff !important;
	height: 45px !important;
	width: 45px !important;
	font-family: Arial;
	font-size: 25pt;
	font-weight: normal;
	cursor: pointer;
}
input.field:hover {
	border: 0;
	color: #900 !important;
}
-->
</style>
		<title>Tic Tac Toe</title>
	
<header>
 <h1>Gato</h1>
 <p>Juego de Gato online</p>
</header>
<br />
<b>Bienvenido!</b> De Inicio a la partida
<br />
<br />&nbsp;No one won. Maybe next time? <a href="?new">Nuevo Juego</a><form method="post">
<table class="tic" style="border-collapse: collapse">
 <tr>
   <td><span style="color: #77e"></span></td>
   <td><span style="color: #e77"></span></td>
   <td><span style="color: #77e"></span></td>
 </tr>
 <tr>
   <td><span style="color: #77e"></span></td>
   <td><span style="color: #e77"></span></td>
   <td><span style="color: #e77"></span></td>
 </tr>
 <tr>
   <td><span style="color: #e77"></span></td>
   <td><span style="color: #77e"></span></td>
   <td><span style="color: #e77"></span></td>
 </tr>
</table>
<p><input type="hidden" name="board" value="OXOOXXXOX" /><br />
</p>
</form><a href="?new">Volver a Iniciar</a>
<h2>Como jugar</h2>
Seleccione una celda con su mouse para poner su marca.
<br />Si no conoce bien las reglas, puede verlas para mayor información en <a href="http://en.wikipedia.org/wiki/Tic-tac-toe" class="external"> Wikipedia</a>.
</asp:Content>