import { Outlet } from 'react-router'
import './ApplicationArea.css'
import { CssBaseline } from '@mui/material'

export default function ApplicationArea(){
    return (
        <>
        <CssBaseline/>
         <Outlet/>
        </>
    )
}
