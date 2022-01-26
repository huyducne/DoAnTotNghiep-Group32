<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="assets/css/index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main-header">
        <div><h5>Danh sách sản phẩm</h5></div>
    </div>

    <div class="product">
        <div class="product-list">
            <asp:Repeater ID="rptSanPham" runat="server">
                <ItemTemplate>
                    <div class="product-item">
                        <h5><%# Eval("TenSP") %></h5>
                        <div><a href="product_detail.aspx?id=<%# Eval("MaSP") %>"><img height ="90%" src="Image/<%# Eval("Hinh") %>" width="200px" /></a></div>
                        <span>Giá: <%# Eval("DonGia","{0:0,00}") %>đ</span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

