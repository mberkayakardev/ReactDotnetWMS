import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

export default defineConfig({
  // proje ayağa kalkacak port bilgisi ayarlandı. 
  server:{
    port: 3000
  },
  plugins: [react()],
})
