use std::env;
use cosmrs::{proto::cosmos::tx::v1beta1::{TxRaw, TxBody}, rpc, tx::{Raw}};
use hex::FromHex;
use cosmos_sdk_proto::{traits::Message, cosmos::tx::v1beta1::AuthInfo};

#[tokio::main]
async fn main() {
    let args: Vec<String> = env::args().collect();
    let buffer = <Vec<u8>>::from_hex("0A8B010A88010A372F446563656E7472616C4361726447616D652E63617264636861696E2E63617264636861696E2E4D736742757943617264536368656D65124D0A296363316C6D3268383366386E756174723878716E776A346B7239323478787A6B74616C30666C6A736C12200A0875637265646974731214313030303030303030303030303030303030303012580A500A460A1F2F636F736D6F732E63727970746F2E736563703235366B312E5075624B657912230A21036CC6A68861BB5D6BF3126EB2CF0E68AED6FD69035A432D33054CCBB56604AC6712040A020801180F120410C09A0C1A407060971E3449EC0A1BF0602EAA044B59D118F7B023AA5BE29033D5318D9D6F745D73966FF735F1070C3D94CED557D4E038B1147D2278489DAE3B97EE876AD008").unwrap();
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
