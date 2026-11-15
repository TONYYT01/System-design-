# 🚀 DWJD Google Drive Integration — Complete Setup Documentation

## Overview
This document tracks the step-by-step setup for integrating Google Drive image uploads into the DWJD backend (Node.js hosted on Render) and frontend (React hosted on Vercel).

---

## Completed Steps

### Step 1: Open Google Cloud Console ✅
- Opened the official Google Cloud Console.
- Selected existing project: **`My Project 8717`**.

### Step 2: Enable Google Drive API ✅
1. Navigated to **APIs & Services → Library**.
2. Searched for **Google Drive API**.
3. Enabled the API to permit backend interactions with Google Drive.

### Step 3: Configure OAuth Consent Screen ✅
1. Navigated to **Google Auth Platform → Branding**:
   - **App name:** `DWJD Profile Upload`
   - **User support email:** Configured Google account
   - **Developer contact email:** Configured contact email
2. Configured **Audience**:
   - Set to **External** for authorizing a personal account.
   - Added `formongodb01@gmail.com` under **Test users** for testing mode.

### Step 4: Create OAuth Client ID ✅
1. Navigated to **Google Auth Platform → Clients**.
2. Clicked **+ Create client** with settings:
   - **Application type:** `Web application`
   - **Name:** `DWJD Profile Upload`
   - **Authorized JavaScript origins:** Blank (used local token-generation script)
   - **Authorized redirect URIs:** `http://localhost:5001/oauth2callback`
3. Obtained **Client ID** and **Client Secret**.

### Step 5: Generate OAuth Refresh Token ✅
1. Executed local token-generation script (`generate-google-token.js`) via CMD.
2. Opened authorization URL and signed in using Account A (`formongodb01@gmail.com`).
3. Approved Google Drive permissions and generated a persistent `refresh_token`.

### Step 6: Configure Render Environment Variables ✅
Set the following environment variables in **Render → Service → Environment**:
- `GOOGLE_OAUTH_CLIENT_ID`
- `GOOGLE_OAUTH_CLIENT_SECRET`
- `GOOGLE_OAUTH_REDIRECT_URI`
- `GOOGLE_OAUTH_REFRESH_TOKEN`

---

## Active Implementation & In-Progress Steps

### Step 7: Update `Mongod.js` Authentication 🔄
Replaced service account authentication (which failed due to `403 Forbidden: Service Accounts do not have storage quota`) with OAuth2 user-delegated authorization:

```javascript
const oauth2Client = new google.auth.OAuth2(
  process.env.GOOGLE_OAUTH_CLIENT_ID,
  process.env.GOOGLE_OAUTH_CLIENT_SECRET,
  process.env.GOOGLE_OAUTH_REDIRECT_URI
);

oauth2Client.setCredentials({
  refresh_token: process.env.GOOGLE_OAUTH_REFRESH_TOKEN,
});

const drive = google.drive({
  version: "v3",
  auth: oauth2Client,
});