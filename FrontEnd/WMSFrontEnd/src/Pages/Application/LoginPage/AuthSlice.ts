import { createAsyncThunk, createSlice } from '@reduxjs/toolkit'
import { jwtDecode, type JwtPayload } from "jwt-decode";
import  AuthService  from '../../../Services/AuthService'
import type { LoginRequest } from "../Interfaces/Concrete/Auth/LoginRequest";
import type { LoginResponse } from "../Interfaces/Concrete/Auth/LoginResponse";
import type { UserInterface } from '../../../Interfaces/Concrete/Auth/UserInterface';



interface AuthState {
  user: UserInterface | null
  loading: boolean
  error: string | null
}

const initialState: AuthState = {
  user: null,
  loading: false,
  error: null,
}

export const loginAsync = createAsyncThunk(
  'auth/login',
  async (credentials: LoginRequest, thunkAPI) => {
    try {
      
      const response = await AuthService.login(credentials)
      
      localStorage.setItem('akarwms-token', JSON.stringify(response))
      
      const decoded = jwtDecode<JwtPayload>(JSON.stringify(response));
        
        const userverable : UserInterface = {
        id: decoded["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"],
        username: decoded["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"],
        email: decoded.email

      };

      return userverable
    } 
    catch (error: any) {
      return thunkAPI.rejectWithValue(error.data.messages)
    }
  }
)

const authSlice = createSlice({
  name: 'auth',
  initialState,
  reducers: {
    logout: (state) => {
      state.user = null
      localStorage.removeItem('token')
    },
  },
  extraReducers: (builder) => {
    builder
      .addCase(loginAsync.pending, (state) => {
        state.loading = true
        state.error = null;
      })
      .addCase(loginAsync.fulfilled, (state, action) => {
        state.user = action.payload
        state.error = null;
        state.loading = false
      })
      .addCase(loginAsync.rejected, (state, action) => {
        state.loading = false
        state.error = action.payload as string
      })
  },
})

export const { logout } = authSlice.actions

export default authSlice.reducer