<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="category.aspx.cs" Inherits="category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="assets/css/index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main-header">
        <div>
            <asp:Repeater ID="rptHangSX" runat="server">
                <ItemTemplate>
                    <h5>Hãng sản xuất: <%# Eval("TenHang") %></h5>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <div class="product">
        <div class="product-list">

            <asp:Repeater ID="rptSanPham" runat="server">
                <ItemTemplate>
                    <div class="product-item">
                        <h5><%# Eval("TenSP") %></h5>
                        <div><a href="product_detail.aspx?id=<%# Eval("MaSP") %>"><img src="Image/<%# Eval("Hinh") %>" width="200px" height="100%" /></a></div>
                        <span>Giá: <%# Eval("DonGia","{0:0,00}") %>đ</span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

