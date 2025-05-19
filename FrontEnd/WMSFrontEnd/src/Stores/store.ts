import { configureStore } from '@reduxjs/toolkit'
import { useDispatch, useSelector } from 'react-redux';
import authReducer from '../Pages/Application/LoginPage/AuthSlice';


export const store = configureStore({
  reducer: {
        auth: authReducer,
  },
})


export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch

/// Type Güvenli kendi costume hook larım 

export const UseAppDispatch = useDispatch.withTypes<AppDispatch>();
export const UseAppSelector = useSelector.withTypes<RootState>();
