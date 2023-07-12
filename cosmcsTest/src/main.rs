use std::env;
use cosmrs::{proto::cosmos::tx::v1beta1::{TxRaw, TxBody}, rpc, tx::{Raw}};
use hex::FromHex;
use cosmos_sdk_proto::{traits::Message, cosmos::tx::v1beta1::AuthInfo};

#[tokio::main]
async fn main() {
    let args: Vec<String> = env::args().collect();
    let buffer = <Vec<u8>>::from_hex(&args[1]).unwrap();
    //cosmrs::proto::cosmos::crypto::ed25519::PubKey
    let msg = TxRaw::decode(&*buffer).unwrap();
    let msg_body = TxBody::decode(&*msg.body_bytes);
    let auth_info = AuthInfo::decode(&*msg.auth_info_bytes).unwrap();
    let pubkey = cosmrs::proto::cosmos::crypto::secp256k1::PubKey::decode(&*auth_info.signer_infos[0].public_key.as_ref().unwrap().value).unwrap();
    //let msg_create_buycardscheme = MsgBuyCardScheme::
    
    println!("\n{:?}", pubkey);
    
    println!("\n{:?}", auth_info);
    
    let rpc_address = format!("http://localhost:{}", 26657);
    let rpc_client = rpc::HttpClient::new(rpc_address.as_str()).unwrap();
    
    let tx_commit_response = Raw::from(msg).broadcast_commit(&rpc_client).await.unwrap();
    
    println!("\n{:?}", tx_commit_response);
}
