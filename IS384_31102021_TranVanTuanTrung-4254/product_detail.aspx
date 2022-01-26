<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="product_detail.aspx.cs" Inherits="product_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="assets/css/product_detail.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="rptSanPham" runat="server">
        <ItemTemplate>
            <div class="product-detail">
                <div class="product-img">
                    <img src="Image/<%# Eval("Hinh") %>" width="300px" />
                </div>
                <div class="product-f">
                    <h4 class="mg-bottom"><%# Eval("TenSP") %></h4>
                    <span style="display: block; color:orangered;">Giá: <%# Eval("DonGia","{0:0,00}") %>đ</span>
                    <div class="buttons_added">
                        <input class="minus is-form" type="button" value="-">
                        <input aria-label="quantity" class="input-qty" max="100" min="1" name="" type="number" value="1">
                        <input class="plus is-form" type="button" value="+">
                    </div>
                    <div class="btn-f">
                        <span style="background-color: #1d4862">Mua ngay</span>                    
                    </div>
                </div>
            </div>
            <div class="description">
                <h5 class="pd-20px">Mô tả</h5>
                <p class="pd-20px" style="margin-top: -20px;">
                    <%# Eval("MoTa") %>
                </p>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

