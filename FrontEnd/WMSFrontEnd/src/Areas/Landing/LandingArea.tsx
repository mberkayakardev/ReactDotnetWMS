import { Outlet } from 'react-router'
import './LandingArea.css'
import { CssBaseline } from '@mui/material'
import Navbar from '../../Components/Landing/Navbar'


export default function LandingArea() {

  return (
    <>
      <CssBaseline/>
      <Navbar/>
      <Outlet/>
    </>
  )
}
