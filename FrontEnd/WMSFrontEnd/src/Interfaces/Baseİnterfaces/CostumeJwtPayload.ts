export default interface CostumeJwtPayload {
  email: string;
  jti: string;
  aud: string[]; // audience listesi
  iss: string;   // issuer
  exp: number;   // expiration
  nbf: number;   // not before
  "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name": string;
  "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier": string;
}
