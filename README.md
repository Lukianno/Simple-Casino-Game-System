# Simple-Casino-Game-System

Description
A minimal real-time casino platform with Auth, Wallet, Lobby, and Game1 services using an ASP.NET Core SignalR backend and a React frontend, all orchestrated with Docker Compose.

## Tech Stack

- ASP.NET Core
- SignalR
- React
- Docker & Docker Compose

## Requirements

- Implement JWT authentication with mock users in Auth Service. (Hint: Use Microsoft.AspNetCore.Authentication.JwtBearer package.)
- Establish SignalR hubs for real-time communication in Lobby and Game1 services. (Hint: Enable CORS for the React client.)
- Create docker-compose.yml to orchestrate all services and the React frontend. (Hint: Ensure correct port mappings and depends_on links.)

## Installation

### Prerequisites

- .NET 6 SDK or later
- Node.js 14+ and npm
- Docker & Docker Compose

### Setup Steps

1. Clone the repository:
   bash
   git clone https://github.com/your-org/Simple-Casino-Game-System.git
   cd Simple-Casino-Game-System
   
2. Create a `.env` file in the root directory with:
   bash
   # JWT settings
   JWT_SECRET=your_jwt_secret_key
   # Frontend URL for CORS
   FRONTEND_URL=http://localhost:3000
   
3. Build and run all services using Docker Compose:
   bash
   docker-compose up --build
   

## Usage

1. Once the containers are running, open the React frontend at http://localhost:3000.
2. Use the mock credentials from the Auth Service to log in.
3. Upon login, you will be directed to the lobby where you can join real-time games.
4. Play Game1 in real time and check your wallet balance for bets and payouts.

## Implementation Steps

1. Scaffold four ASP.NET Core Web API projects: `AuthService`, `WalletService`, `LobbyService`, and `Game1Service`.
2. In `AuthService`:
   - Add `Microsoft.AspNetCore.Authentication.JwtBearer` package.
   - Configure JWT in `Startup.cs` (or `Program.cs`).
   - Create a mock user store and implement a `/api/auth/login` endpoint that issues tokens.
3. In `WalletService`:
   - Implement in-memory wallet balances.
   - Secure endpoints using `[Authorize]` requiring a valid JWT.
4. In `LobbyService` and `Game1Service`:
   - Add SignalR hubs (`LobbyHub`, `Game1Hub`).
   - Enable CORS to allow connections from `http://localhost:3000`.
   - Define hub methods for joining rooms, broadcasting messages, and game events.
5. Create the React frontend:
   - Use `create-react-app`.
   - Implement authentication flow storing the JWT in memory or localStorage.
   - Connect to SignalR hubs using `@microsoft/signalr`.
   - Build lobby and game UIs with real-time updates.
6. Add Docker support:
   - Write `Dockerfile` for each ASP.NET Core service.
   - Write `Dockerfile` for the React app.
7. Create `docker-compose.yml`:
   - Define services for each API, the React frontend, and set correct port mappings (e.g., 5001, 5002, 5003, 5004, 3000).
   - Use `depends_on` to ensure ordering.
8. Test end-to-end by bringing up the stack, logging in, and playing a game.

(Optional) ## API Endpoints

- POST /api/auth/login  
- GET /api/wallet/balance  
- POST /api/wallet/deposit

- SignalR endpoints:
  - /lobbyHub
  - /game1Hub