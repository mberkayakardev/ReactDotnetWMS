import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import { NavLink } from 'react-router';
import { UseAppSelector } from '../../Stores/store';

const navStyles = {
    color: "inherit",
    textDecoration:"none",
    "&:hover":{
        color:"text.primary"
    },
    "&.active":{
        color:"warning.main"
    }
}

export default function ButtonAppBar() {


    const user = UseAppSelector((state) => state.auth.user);

  return (
 <AppBar position="static" color="primary">
      <Toolbar sx={{ display: 'flex', justifyContent: 'space-between' }}>
        
        <Typography variant="h6" component={NavLink}   to="/" sx={{textDecoration:"none", color:"white"}}> Akar WMS </Typography>

        <Box sx={{ position: 'absolute', left: '50%', transform: 'translateX(-50%)', display: 'flex', gap: 2 }}>
          <Button color="inherit" component={NavLink} sx={navStyles} to="/">HAKKINDA</Button>
          <Button color="inherit" component={NavLink} sx={navStyles} to="/history">İŞ TANIMI</Button>
        </Box>

    
      {user ? (
      
          <Typography sx={{ color: "white" }}  component={NavLink} to="/admin/dashboard" > Hoş geldin, {user.username} </Typography>
      ) : (
        <Button color="inherit" component={NavLink} to="/login" sx={navStyles}> Giriş Yap </Button>
        
      )}

      </Toolbar>
    </AppBar>
  );
}