<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="MemberShip.KayitOl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" AnswerLabelText="Gizli Cevap:" AnswerRequiredErrorMessage="Gizli Cevap Boş Geçilemez" CompleteSuccessText="Kullanıcı Hesabı Başarıyla Oluşturuldu." ConfirmPasswordCompareErrorMessage="Girilen Parolalar Uyuşmuyor." ConfirmPasswordLabelText="Parola Tekrar:" ConfirmPasswordRequiredErrorMessage="Parola Tekrarı Boş Geçilemez." ContinueButtonText="İleri" ContinueDestinationPageUrl="~/GirisYap.aspx" CreateUserButtonText="Kullanıcı Oluştur" DuplicateEmailErrorMessage="Bu E-Mail'e Ait Kayıtlı Bir Kullanıcı Var." DuplicateUserNameErrorMessage="Bu KullanıcıAdı'na Ait Kayıtlı Bir Kullanıcı Zaten Mevcut." EmailRegularExpressionErrorMessage="Geçersiz E-Mail Adresi" EmailRequiredErrorMessage="E-Mail Adresi Boş Geçilemez." FinishCompleteButtonText="Bitti" FinishDestinationPageUrl="~/GirisYap.aspx" InvalidAnswerErrorMessage="Geçersiz Gizli Cevap." InvalidEmailErrorMessage="Geçersiz E-Mail Adresi" InvalidPasswordErrorMessage="Geçersiz Parola." InvalidQuestionErrorMessage="Geçersiz Gizli Soru." PasswordLabelText="Parola:" PasswordRegularExpressionErrorMessage="Girilen Parola Kurallara Uymuyor." PasswordRequiredErrorMessage="Parola Boş Geçilemez." QuestionLabelText="Gizli Soru:" QuestionRequiredErrorMessage="Gizli Soru Boş Geçilemez." StartNextButtonText="İleri" UnknownErrorMessage="Hesabınız Oluşturulamadı.Lütfen Tekrar Deneyiniz." UserNameLabelText="Kullanıcı Adı:" UserNameRequiredErrorMessage="Kullanıcı Adı Boş Geçilemez.">
                <WizardSteps>
                    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                    </asp:CreateUserWizardStep>
                    <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                    </asp:CompleteWizardStep>
                </WizardSteps>
            </asp:CreateUserWizard>
        </div>
    </form>
</body>
</html>
