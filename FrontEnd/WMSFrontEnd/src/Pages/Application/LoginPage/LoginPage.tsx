import { useForm } from "react-hook-form";
import { Box, Button, Container, Paper, TextField, Typography, } from "@mui/material";
import { UseAppDispatch, UseAppSelector } from "../../../Stores/store";
import { loginAsync } from "./AuthSlice";
import { router } from "../../../Routers/AppRouter";
import { Router } from "react-router";


 

export default function LoginPage() {
  
    const { register, handleSubmit, formState: { errors },  } = useForm<LoginFormInputs>();
    
    const dispatch = UseAppDispatch();
    const auth = UseAppSelector((state) => state.auth);
  
    const onSubmit = async  (data: LoginRequest) => {
    
      let response = await  dispatch(loginAsync(data)).unwrap();

      console.log(auth)

      if (auth.error === null )
        {
          router.navigate("/admin/dashboard");
        }

    };

  return (
    <Container maxWidth="sm">
      <Paper elevation={3} sx={{ padding: 4, mt: 8 }}>
        <Typography variant="h5" align="center" gutterBottom> Giriş Yap </Typography>

        <Box component="form" onSubmit={handleSubmit(onSubmit)} noValidate>
            <TextField fullWidth margin="normal"  label="E-posta"  type="email"
            {...register("email", {
              required: "E-posta zorunludur."
            })}
            error={!!errors.email}
            helperText={errors.email?.message}
          />

          <TextField
            fullWidth
            margin="normal"
            label="Şifre"
            type="password"
            {...register("password", {
              required: "Şifre zorunludur."
            })}
            error={!!errors.password}
            helperText={errors.password?.message}
          />

          <Button
            type="submit"
            fullWidth
            variant="contained"
            sx={{ mt: 2 }}
          >
            Giriş Yap
          </Button>
        </Box>
      </Paper>
    </Container>
  );
}
