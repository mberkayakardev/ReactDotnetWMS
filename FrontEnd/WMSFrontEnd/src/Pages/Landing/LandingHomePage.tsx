import { Container, Grid, Paper, Typography, Box } from "@mui/material";
import AkarWMS from "../../Assets/AkarWMS.png";

export default function LandingHomePage() {
  return (
    <Container maxWidth="lg">
      {/* Başlık */}
      <Paper elevation={4} sx={{ padding: 2, mt: 4 }}>
        <Typography variant="h3" sx={{ textAlign: "center" }}>
          Akar WMS
        </Typography>
      </Paper>

      {/* İçerik */}
      <Paper elevation={2} sx={{ padding: 4, mt: 4 }}>
        <Box sx={{ display: "flex", flexDirection: "row", alignItems: "center", gap: 4, flexWrap: "nowrap" }}>
          {/* Sol: Resim */}
          <Box sx={{ flexShrink: 0 }}>
            <img
              src={AkarWMS}
              alt="Akar WMS Logo"
              style={{
                width: "300px",
                height: "auto",
                borderRadius: "10px",
              }}
            />
          </Box>

          {/* Sağ: Yazı */}
          <Box>
            <Typography variant="h5" sx={{textAlign:"center" , mb:4}} gutterBottom>
             Akıllı Depolar, Güçlü İşletmeler
            </Typography>
            <Typography variant="body1">
            Akar WMS, yalnızca bir yazılım değil; lojistik süreçlerinizi hızlandıran, hata payını azaltan ve iş gücünü optimize eden bir akıllı çözüm ortağıdır. Entegre yapısıyla depo yönetimini dijitalleştirir, iş akışlarını otomatikleştirir ve gerçek zamanlı kontrol imkânı sunar. Gelişmiş teknoloji altyapısı sayesinde, işletmenizin verimliliğini geleceğe taşır.
            </Typography>
          </Box>
        </Box>
      </Paper>
    </Container>
  );
}
