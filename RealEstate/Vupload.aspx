<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Vupload.aspx.vb" Inherits="RealEstate.Vupload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 73px;
        }
        .auto-style3 {
            height: 23px;
            width: 73px;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            width: 322px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Button ID="Button1" runat="server" Text="Back" />
            <br />
            Upload a property<br />
        </div>
        <div style=" margin-left: auto; margin-right: auto; text-align: right;">
        <p>
            <table align="center" class="auto-style5">
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
            <asp:TextBox ID="namebox" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date of aval</td>
                    <td>
            <asp:TextBox ID="datebox" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Address</td>
                    <td class="auto-style1">
            <asp:TextBox ID="addrbox" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Purpose</td>
                    <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="100%" AutoPostBack="true">
                <asp:ListItem>Sell</asp:ListItem>
                <asp:ListItem>Rent</asp:ListItem>
            </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">Type</td>
                    <td>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Width="100%">
                <asp:ListItem Value="0">Empty Property</asp:ListItem>
                <asp:ListItem Value="1">Building</asp:ListItem>
                <asp:ListItem Value="2">Appartment</asp:ListItem>
            </asp:DropDownList>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">Size</td>
                    <td>
            <asp:TextBox ID="sizebox" runat="server" Width="100%"></asp:TextBox>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">Price</td>
                    <td>
            <asp:TextBox ID="pricebox" runat="server" Width="100%"></asp:TextBox>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
            <asp:Label ID="Floor" runat="server" Text="Floor" ></asp:Label>
                     </td>
                    <td><asp:TextBox ID="floorbox" runat="server" Enabled="False" Width="100%"></asp:TextBox>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
            <asp:Label ID="Floors" runat="server" Text="Floors"></asp:Label>
                     </td>
                    <td><asp:TextBox ID="floorsbox" runat="server" Enabled="False" Width="100%"></asp:TextBox>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
            <asp:Label ID="Rooms" runat="server" Text="Rooms"></asp:Label>
                     </td>
                    <td><asp:TextBox ID="roomsbox" runat="server" Enabled="False" Width="100%"></asp:TextBox>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
            <asp:Label ID="construction" runat="server" Text="Constructed at"></asp:Label>
                     </td>
                    <td><asp:TextBox ID="constructbox" runat="server" Enabled="False" Width="100%"></asp:TextBox>
                     </td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Features"></asp:Label>
                     </td>
                    <td><asp:TextBox ID="featurebox" runat="server" Width="100%"></asp:TextBox>
                     </td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="terms" runat="server" Text="Terms"></asp:Label>
                     </td>
                    <td><asp:CheckBox ID="terms_accept" runat="server" Text="Accept"/>
                     </td>
                </tr>
            </table>
        </p>
            <p class="auto-style4">
                <asp:TextBox ID="TextBox1" runat="server" Height="118px" ReadOnly="True" TextMode="MultiLine" Width="329px">Last updated: December 19, 2018

 Please read these Terms and Conditions (&quot;Terms&quot;, &quot;Terms and Conditions&quot;)
carefully before using the Real Estate App website (the &quot;Service&quot;) operated by
Real Estate (&quot;us&quot;, &quot;we&quot;, or &quot;our&quot;).

Your access to and use of the Service is conditioned on your acceptance of and
compliance with these Terms. These Terms apply to all visitors, users and
others who access or use the Service.

By accessing or using the Service you agree to be bound by these Terms. If you
disagree with any part of the terms then you may not access the Service. The
Terms and Conditions agreement for Real Estate is based on the [TermsFeed&#39;s
Terms and Conditions Template](https://termsfeed.com/blog/sample-terms-and-
conditions-template/).

Accounts  
--------

When you create an account with us, you must provide us information that is
accurate, complete, and current at all times. Failure to do so constitutes a
breach of the Terms, which may result in immediate termination of your account
on our Service.

You are responsible for safeguarding the password that you use to access the
Service and for any activities or actions under your password, whether your
password is with our Service or a third-party service.

You agree not to disclose your password to any third party. You must notify us
immediately upon becoming aware of any breach of security or unauthorized use
of your account.

Links To Other Web Sites  
------------------------

Our Service may contain links to third-party web sites or services that are
not owned or controlled by Real Estate.

Real Estate has no control over, and assumes no responsibility for, the
content, privacy policies, or practices of any third party web sites or
services. You further acknowledge and agree that Real Estate shall not be
responsible or liable, directly or indirectly, for any damage or loss caused
or alleged to be caused by or in connection with use of or reliance on any
such content, goods or services available on or through any such web sites or
services.

We strongly advise you to read the terms and conditions and privacy policies
of any third-party web sites or services that you visit.

Termination  
-----------

We may terminate or suspend access to our Service immediately, without prior
notice or liability, for any reason whatsoever, including without limitation
if you breach the Terms.

All provisions of the Terms which by their nature should survive termination
shall survive termination, including, without limitation, ownership
provisions, warranty disclaimers, indemnity and limitations of liability.

We may terminate or suspend your account immediately, without prior notice or
liability, for any reason whatsoever, including without limitation if you
breach the Terms.

Upon termination, your right to use the Service will immediately cease. If you
wish to terminate your account, you may simply discontinue using the Service.

All provisions of the Terms which by their nature should survive termination
shall survive termination, including, without limitation, ownership
provisions, warranty disclaimers, indemnity and limitations of liability.

Governing Law  
-------------

These Terms shall be governed and construed in accordance with the laws of
Greece, without regard to its conflict of law provisions.

Our failure to enforce any right or provision of these Terms will not be
considered a waiver of those rights. If any provision of these Terms is held
to be invalid or unenforceable by a court, the remaining provisions of these
Terms will remain in effect. These Terms constitute the entire agreement
between us regarding our Service, and supersede and replace any prior
agreements we might have between us regarding the Service.

Changes  
-------

We reserve the right, at our sole discretion, to modify or replace these Terms
at any time. If a revision is material we will try to provide at least 15 days
notice prior to any new terms taking effect. What constitutes a material
change will be determined at our sole discretion.

By continuing to access or use our Service after those revisions become
effective, you agree to be bound by the revised terms. If you do not agree to
the new terms, please stop using the Service.

Contact Us  
----------

If you have any questions about these Terms, please contact us.

</asp:TextBox>
        </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <p style=" margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Button ID="Upload" runat="server" Text="Upload" style="text-align: right;"/>
        </p>
        <p style=" margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label ID="errorlabel" runat="server" Text="Terms not accepted" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
